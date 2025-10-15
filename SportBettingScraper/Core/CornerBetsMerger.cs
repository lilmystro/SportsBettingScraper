using SportBettingScraper.Models;

namespace SportBettingScraper.Core;

public static class CornerBetsMerger
{
    public static List<TeamCornerStats> GetMergedEntries()
    {
        // update these paths
        string overallPath = @"C:\Dev\FootballLeagueApi\SportBettingScraper\SportBettingScraper\corners_overall.csv";
        string homePath = @"C:\Dev\FootballLeagueApi\SportBettingScraper\SportBettingScraper\corners_home.csv";
        string awayPath = @"C:\Dev\FootballLeagueApi\SportBettingScraper\SportBettingScraper\corners_away.csv";

        var overall = LeagueCornersScraper.ReadCornersCsv(overallPath);
        var home = LeagueCornersScraper.ReadCornersCsv(homePath);
        var away = LeagueCornersScraper.ReadCornersCsv(awayPath);

        var merged = LeagueCornersScraper.MergeEntries(overall, home, away);

        return merged;
    }
}
