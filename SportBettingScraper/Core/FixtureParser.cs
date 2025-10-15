using SportBettingScraper.Models;
using System.Text.RegularExpressions;

namespace SportBettingScraper.Core;
public static class FixtureParser
{
    public static List<Fixture> Parse(string leagueName, string text)
    {
        var fixtures = new List<Fixture>();

        // Split the text into lines and clean it
        var lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries)
                        .Select(l => l.Trim())
                        .ToList();

        for (int i = 0; i < lines.Count - 4; i++)
        {
            if (Regex.IsMatch(lines[i], @"\d{1,2}\s?[A-Z]{3}", RegexOptions.IgnoreCase) && // date like "18 OCT"
                Regex.IsMatch(lines[i + 1], @"\d{1,2}:\d{2}", RegexOptions.IgnoreCase) &&   // time like "13:30"
                !string.IsNullOrWhiteSpace(lines[i + 2]) &&
                !string.IsNullOrWhiteSpace(lines[i + 3]) &&
                lines[i + 4].Equals("Favourites", StringComparison.OrdinalIgnoreCase))
            {
                fixtures.Add(new Fixture
                {
                    League = leagueName,
                    Date = lines[i],
                    Time = lines[i + 1],
                    HomeTeam = lines[i + 2],
                    AwayTeam = lines[i + 3]
                });
            }
        }

        return fixtures;
    }
}
