using SportBettingScraper.Models;
using System.Text.RegularExpressions;

namespace SportBettingScraper.Core;

public static class Scraper
{
    public static async Task<List<Team>> GetStandings(string url)
    {
        using var client = new HttpClient();
        var html = await client.GetStringAsync(url);

        var doc = new HtmlAgilityPack.HtmlDocument();
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
                Home = home,
                Away = away,
                Time = time
            });

            searchIndex = sentenceEnd + 1;
        }

        return fixtures;
    }
}
