using HtmlAgilityPack;
using SportBettingScraper.Models;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SportBettingScraper.Core;

public static class Scraper
{
    public static async Task<List<Team>> GetStandings(string url)
    {
        using var client = new HttpClient();

        try
        {
            // Send a HEAD request first to verify if the URL exists
            var headResponse = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));
            if (!headResponse.IsSuccessStatusCode)
            {
                Console.WriteLine($"❌ URL not reachable: {url} (Status: {(int)headResponse.StatusCode})");
                return new List<Team>();
            }

            // Now safely fetch the HTML
            var html = await client.GetStringAsync(url);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var rawText = doc.DocumentNode.InnerText;

            var standings = new List<Team>();
            var startIndex = rawText.IndexOf("Points");
            if (startIndex == -1) return standings;

            var tableSection = rawText.Substring(startIndex);

            var rowPattern = new Regex(@"(?<pos>\d+)\s+(?<team>[A-Za-z &]+)\s+(?<played>\d+)\s+(?<won>\d+)\s+(?<drawn>\d+)\s+(?<lost>\d+)\s+(?<for>\d+)\s+(?<against>\d+)\s+(?<gd>[+\-]?\d+)\s+(?<pts>\d+)", RegexOptions.Multiline);

            foreach (Match match in rowPattern.Matches(tableSection))
            {
                standings.Add(new Team
                {
                    Position = int.Parse(match.Groups["pos"].Value),
                    Name = match.Groups["team"].Value.Trim()
                });
            }

            return standings;

        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"❌ Request error: {url} ({ex.Message})");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Unexpected error fetching {url}: {ex.Message}");
        }
        return  new List<Team>();
    }

    public static async Task<List<Fixture>> GetFixtures(string url)
    {
        using var client = new HttpClient();
        var html = await client.GetStringAsync(url);

        var doc = new HtmlAgilityPack.HtmlDocument();
        doc.LoadHtml(html);

        var fixtures = new List<Fixture>();
        var rawText = doc.DocumentNode.InnerText;

        string markerA = "are scheduled to play";
        string markerB = "View fixture";
        Regex timeRegex = new(@"\d{1,2}\.\d{2}[ap]m", RegexOptions.IgnoreCase);

        int searchIndex = 0;
        while (true)
        {
            int aIndex = rawText.IndexOf(markerA, searchIndex, StringComparison.OrdinalIgnoreCase);
            if (aIndex == -1) break;

            int sentenceEnd = rawText.IndexOf('.', aIndex);
            if (sentenceEnd == -1) break;

            string afterA = rawText.Substring(aIndex + markerA.Length, sentenceEnd - (aIndex + markerA.Length)).Trim();

            var timeMatch = timeRegex.Match(rawText, sentenceEnd);
            string time = timeMatch.Success ? timeMatch.Value : "Unknown";

            string away = afterA;
            if (timeMatch.Success)
            {
                int timePos = away.IndexOf(timeMatch.Value, StringComparison.OrdinalIgnoreCase);
                if (timePos >= 0)
                    away = away.Substring(0, timePos).Trim().Trim('.');
            }

            int bIndex = rawText.LastIndexOf(markerB, aIndex, StringComparison.OrdinalIgnoreCase);
            if (bIndex == -1) break;

            string home = rawText.Substring(bIndex + markerB.Length, aIndex - (bIndex + markerB.Length)).Trim();

            fixtures.Add(new Fixture
            {
                HomeTeam = home,
                AwayTeam = away,
                Time = time
            });

            searchIndex = sentenceEnd + 1;
        }

        return fixtures;
    }

    // Try to parse the combined teams string by brute-force splitting using the team list
    // teams parameter = list of canonical team names (e.g. "Manchester United", "Chelsea", ...)
    public static (bool success, string home, string away) TryParseCombinedTeamsByTeamList(string combinedRaw, List<string> teams)
    {
        if (string.IsNullOrWhiteSpace(combinedRaw) || teams == null || teams.Count == 0)
            return (false, null, null);

        // Normalize combined string (remove spaces/punctuation)
        var combinedNorm = NormalizeName(combinedRaw);

        // Build a dictionary from normalized -> original (distinct)
        var teamDict = teams
            .Where(t => !string.IsNullOrWhiteSpace(t))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToDictionary(t => NormalizeName(t), t => t, StringComparer.OrdinalIgnoreCase);

        if (string.IsNullOrEmpty(combinedNorm))
            return (false, null, null);

        // 1) Exact split brute-force: try every possible split position and see if left/right equal known teams
        for (int split = 1; split < combinedNorm.Length; split++)
        {
            var left = combinedNorm.Substring(0, split);
            var right = combinedNorm.Substring(split);

            if (teamDict.TryGetValue(left, out var leftOriginal)
                && teamDict.TryGetValue(right, out var rightOriginal)
                && !string.Equals(leftOriginal, rightOriginal, StringComparison.OrdinalIgnoreCase))
            {
                // left -> home, right -> away (because the home team is after the time)
                return (true, leftOriginal, rightOriginal);
            }
        }

        // 2) Fallback: find the longest team name that matches the start and the longest that matches the end
        var startMatch = teamDict.Keys
            .Where(k => combinedNorm.StartsWith(k, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(k => k.Length)
            .FirstOrDefault();

        var endMatch = teamDict.Keys
            .Where(k => combinedNorm.EndsWith(k, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(k => k.Length)
            .FirstOrDefault();

        if (!string.IsNullOrEmpty(startMatch) && !string.IsNullOrEmpty(endMatch) && !string.Equals(startMatch, endMatch, StringComparison.OrdinalIgnoreCase))
        {
            return (true, teamDict[startMatch], teamDict[endMatch]);
        }

        // 3) Another fallback: find all occurrences of any team norms inside the combined string and pick earliest + latest distinct
        var occurrences = new List<(int pos, string norm, string original)>();
        foreach (var kv in teamDict)
        {
            int idx = combinedNorm.IndexOf(kv.Key, StringComparison.OrdinalIgnoreCase);
            if (idx >= 0)
                occurrences.Add((idx, kv.Key, kv.Value));
        }

        if (occurrences.Count >= 2)
        {
            occurrences = occurrences.OrderBy(o => o.pos).ToList();
            var first = occurrences.First();
            var last = occurrences.Last();
            if (!string.Equals(first.original, last.original, StringComparison.OrdinalIgnoreCase))
                return (true, first.original, last.original);
        }

        // 4) Not found
        return (false, null, null);
    }

    // Normalize names: remove non-alphanumeric and lowercase for robust matching
    public static string NormalizeName(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return "";
        return Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLowerInvariant();
    }

    // Main scraping method: extracts time + combined teams from DocumentNode.InnerText then resolves teams via teamList
    public static async Task<List<Fixture>> ScrapeLeagueFixturesUsingTeamListAsync(string leagueUrl, string leagueName, List<string>? teamList = null, HttpClient client = null)
    {
        var fixtures = FixtureParser.Parse(leagueName, await PlayWrightScraper.GetFixtures(leagueUrl));

        return fixtures;
    }
}
