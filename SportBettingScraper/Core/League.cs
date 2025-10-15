using SportBettingScraper.Models;

namespace SportBettingScraper.Core;

public class League
{
    public string Name { get; }
    public string TableUrl { get; }
    public string FixturesUrl { get; }

    public List<Team> Standings { get; private set; } = new();
    public List<Fixture> Fixtures { get; private set; } = new();

    public List<string> TeamsList { get; private set; } = new();

    public League(string name, string tableUrl, string fixturesUrl, List<string>? teamList = null)
    {
        Name = name;
        TableUrl = tableUrl;
        FixturesUrl = fixturesUrl;
        TeamsList = teamList ?? new List<string>();
    }

    public async Task FetchStandingsAsync()
    {
        Standings = await Scraper.GetStandings(TableUrl);
    }

    public async Task FetchFixturesAsync()
    {
        //Fixtures = await Scraper.GetFixtures(FixturesUrl);
        Fixtures = await Scraper.ScrapeLeagueFixturesUsingTeamListAsync(FixturesUrl, Name, TeamsList);
    }
}
