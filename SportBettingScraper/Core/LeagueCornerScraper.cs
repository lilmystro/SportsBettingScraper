using CsvHelper;
using CsvHelper.Configuration;
using SportBettingScraper.Models;
using System.Globalization;

namespace SportBettingScraper.Core;

public static class LeagueCornersScraper
{
    // --- Read CSV robustly (detects header name variants) ---
    public static List<CornerEntry> ReadCornersCsv(string path)
    {
        if (!File.Exists(path))
            return new List<CornerEntry>();

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            MissingFieldFound = null,
            BadDataFound = null,
            HeaderValidated = null
        };

        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, config);

        csv.Read();
        csv.ReadHeader();
        var headers = csv.HeaderRecord.Select(h => h?.Trim()).ToArray();

        bool isHome = path.Contains("home", StringComparison.OrdinalIgnoreCase);
        bool isAway = path.Contains("away", StringComparison.OrdinalIgnoreCase);
        bool isOverall = path.Contains("overall", StringComparison.OrdinalIgnoreCase);

        // Home / Away / Overall column sets
        string gamesCol, cfCol, caCol;

        if (isHome)
        {
            gamesCol = "GH";
            cfCol = "CFHFT";
            caCol = "CAHFT";
        }
        else if (isAway)
        {
            gamesCol = "GA";
            cfCol = "CFAFT";
            caCol = "CAAFT";
        }
        else // default to overall
        {
            gamesCol = "GA";
            cfCol = "CFAFT";
            caCol = "CAAFT";
        }

        var list = new List<CornerEntry>();

        while (csv.Read())
        {
            string league = csv.GetField("League")?.Trim() ?? "";
            string team = csv.GetField("Team")?.Trim() ?? "";

            double ParseDouble(string col)
            {
                if (string.IsNullOrEmpty(col)) return 0;
                var value = csv.GetField(col);
                if (string.IsNullOrWhiteSpace(value)) return 0;
                value = value.Replace("%", "").Trim();
                if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
                    return result;
                if (double.TryParse(value.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
                    return result;
                return 0;
            }

            var entry = new CornerEntry
            {
                League = league,
                Team = team,
                Games = ParseDouble(gamesCol),
                CF = ParseDouble(cfCol),
                CA = ParseDouble(caCol)
            };

            list.Add(entry);
        }

        Console.WriteLine($"Loaded {list.Count} records from {Path.GetFileName(path)}");
        return list;
    }

    // --- Merge overall/home/away into a combined list ---
    public static List<TeamCornerStats> MergeEntries(List<CornerEntry> overall, List<CornerEntry> home, List<CornerEntry> away)
    {
        // Build unique key set
        var keys = overall.Select(x => (x.League, x.Team))
                          .Union(home.Select(x => (x.League, x.Team)))
                          .Union(away.Select(x => (x.League, x.Team)))
                          .Distinct();

        var results = new List<TeamCornerStats>();

        foreach (var (league, team) in keys)
        {
            var o = overall.FirstOrDefault(x => string.Equals(x.League, league, StringComparison.OrdinalIgnoreCase)
                                             && string.Equals(x.Team, team, StringComparison.OrdinalIgnoreCase));
            var h = home.FirstOrDefault(x => string.Equals(x.League, league, StringComparison.OrdinalIgnoreCase)
                                           && string.Equals(x.Team, team, StringComparison.OrdinalIgnoreCase));
            var a = away.FirstOrDefault(x => string.Equals(x.League, league, StringComparison.OrdinalIgnoreCase)
                                           && string.Equals(x.Team, team, StringComparison.OrdinalIgnoreCase));

            // prefer overall if present and non-zero
            double totalCF, totalCA;

            if (o != null && o.Games > 0 && (o.CF != 0 || o.CA != 0))
            {
                totalCF = o.CF;
                totalCA = o.CA;
            }
            else if (h != null && a != null && (h.Games + a.Games) > 0)
            {
                // weighted average by games to approximate overall
                var totalGames = h.Games + a.Games;
                totalCF = (h.CF * h.Games + a.CF * a.Games) / totalGames;
                totalCA = (h.CA * h.Games + a.CA * a.Games) / totalGames;
            }
            else if (h != null && h.Games > 0)
            {
                totalCF = h.CF;
                totalCA = h.CA;
            }
            else if (a != null && a.Games > 0)
            {
                totalCF = a.CF;
                totalCA = a.CA;
            }
            else
            {
                // fallback: use whatever numbers exist
                totalCF = o?.CF ?? h?.CF ?? a?.CF ?? 0;
                totalCA = o?.CA ?? h?.CA ?? a?.CA ?? 0;
            }

            results.Add(new TeamCornerStats
            {
                League = league,
                Team = team,
                TotalCornersFor = Math.Round(totalCF, 2),
                TotalCornersAgainst = Math.Round(totalCA, 2),
                HomeCornersFor = Math.Round(h?.CF ?? 0, 2),
                HomeCornersAgainst = Math.Round(h?.CA ?? 0, 2),
                AwayCornersFor = Math.Round(a?.CF ?? 0, 2),
                AwayCornersAgainst = Math.Round(a?.CA ?? 0, 2)
            });
        }

        return results;
    }

    // --- Pretty-print grouped by league ---
    public static void PrintLeagueTables(List<TeamCornerStats> merged)
    {
        var grouped = merged.GroupBy(x => x.League).OrderBy(g => g.Key);

        foreach (var leagueGroup in grouped)
        {
            Console.WriteLine($"\n=== {leagueGroup.Key} ===");
            Console.WriteLine(new string('-', 160));

            // header columns (wider to avoid wrapping)
            Console.WriteLine("{0,-35} | {1,9} | {2,11} | {3,11} | {4,11} | {5,11} | {6,11} | {7,11} | {8,11} | {9,11}",
                "Team",
                "Tot", "TotFor", "TotAg",
                "HomeTot", "HomeFor", "HomeAg",
                "AwayTot", "AwayFor", "AwayAg");
            Console.WriteLine(new string('-', 160));

            foreach (var t in leagueGroup.OrderBy(x => x.Team))
            {
                Console.WriteLine("{0,-35} | {1,9:F2} | {2,11:F2} | {3,11:F2} | {4,11:F2} | {5,11:F2} | {6,11:F2} | {7,11:F2} | {8,11:F2} | {9,11:F2}",
                    t.Team,
                    t.TotalCorners, t.TotalCornersFor, t.TotalCornersAgainst,
                    t.TotalHomeCorners, t.HomeCornersFor, t.HomeCornersAgainst,
                    t.TotalAwayCorners, t.AwayCornersFor, t.AwayCornersAgainst);
            }
        }
    }

    public static void PrintLowCornerBets(List<League> leagues, List<TeamCornerStats> merged)
    {
        Console.WriteLine("\n=============================");
        Console.WriteLine("📊 POTENTIAL LOW CORNER GAMES");
        Console.WriteLine("=============================\n");

        var lowCornerThreshold = 9.0;
        var lowCornerThresholdMax = 9.5;

        foreach (var league in leagues.OrderBy(l => l.Name))
        {
            if (league.Fixtures == null || !league.Fixtures.Any())
                continue;

            // get aliases dynamically for this league
            var aliases = LivescoreLeagues.GetTeamAliases(league.Name);

            Console.WriteLine($"\n=== {league.Name} ===");
            Console.WriteLine(new string('-', 140));
            Console.WriteLine("{0,-40} | {1,10} | {2,10} | {3,-25} | {4,10} | {5,10} | {6,10} | {7,10}",
                "Home Team", "HomeTotal", "HomeFor", "Away Team", "AwayTotal", "AwayFor", "HomeAwayTotal", "GrandTotal");
            Console.WriteLine(new string('-', 140));

            var printedAny = false;

            foreach (var fixture in league.Fixtures)
            {
                var home = NormalizeTeamName(fixture.HomeTeam, aliases, merged);
                var away = NormalizeTeamName(fixture.AwayTeam, aliases, merged);

                if (home == null || away == null)
                {
                    Console.WriteLine($"[ALIAS NEEDED] {league.Name}: \"{fixture.HomeTeam}\" vs \"{fixture.AwayTeam}\"");
                    continue;
                }

                double homeAwayTotal = home.HomeCornersFor + away.AwayCornersFor;
                double grandTotal = home.TotalCornersFor + away.TotalCornersFor;

                if ((homeAwayTotal < lowCornerThreshold) &&
                    (grandTotal < lowCornerThresholdMax))
                {
                    printedAny = true;
                    Console.WriteLine("{0,-40} | {1,10:F2} | {2,10:F2} | {3,-25} | {4,10:F2} | {5,10:F2} | {6,10:F2} | {7,10:F2}",
                        home.Team,
                        home.TotalCornersFor,
                        home.HomeCornersFor,
                        away.Team,
                        away.TotalCornersFor,
                        away.AwayCornersFor,
                        homeAwayTotal,
                        grandTotal);
                }
            }

            if (!printedAny)
                Console.WriteLine($"No fixtures under {lowCornerThreshold} HomeAway total corners found.");

            Console.WriteLine(new string('-', 140));
        }
    }

    private static TeamCornerStats? NormalizeTeamName(string liveScoreName, IDictionary<string, string>? aliases, List<TeamCornerStats> merged)
    {
        if (string.IsNullOrWhiteSpace(liveScoreName) || merged == null)
            return null;

        // Build all possible names that could represent this team.
        // Include the original LiveScore name so it works when there is no alias.
        var candidates = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            liveScoreName.Trim()
        };

        // If aliases are provided, add any matching alias key/value pairs to the candidate set.
        if (aliases != null && aliases.Count > 0)
        {
            foreach (var kv in aliases)
            {
                if (kv.Key.Equals(liveScoreName, StringComparison.OrdinalIgnoreCase) ||
                    kv.Value.Equals(liveScoreName, StringComparison.OrdinalIgnoreCase))
                {
                    candidates.Add(kv.Key);   // canonical/csv name
                    candidates.Add(kv.Value); // alt/live name
                }
            }
        }

        // Single pass: return the first merged entry whose Team matches any candidate.
        return merged.FirstOrDefault(t => candidates.Contains(t.Team));
    }
}
