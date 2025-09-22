namespace SportBettingScraper.Core;

public class LivescoreLeagues
{
    public static List<League> GetLeagues()
    {
        return
        [
            new League("Premier League",
                       "https://www.livescore.com/en/football/england/premier-league/standings/",
                       "https://www.livescore.com/en/football/england/premier-league/fixtures/"),
            new League("Bundesliga",
                       "https://www.livescore.com/en/football/germany/bundesliga/standings/",
                       "https://www.livescore.com/en/football/germany/bundesliga/fixtures/"),
            new League("La Liga",
                       "https://www.livescore.com/en/football/spain/laliga/standings/",
                       "https://www.livescore.com/en/football/spain/laliga/fixtures/"),
            new League("Serie A",
                       "https://www.livescore.com/en/football/italy/serie-a/standings/",
                       "https://www.livescore.com/en/football/italy/serie-a/fixtures/"),
            new League("Ligue 1",
                       "https://www.livescore.com/en/football/france/ligue-1/standings/",
                       "https://www.livescore.com/en/football/france/ligue-1/fixtures/"),
        ];
    }
}
