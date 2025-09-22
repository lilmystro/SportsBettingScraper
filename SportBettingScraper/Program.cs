using SportBettingScraper.Core;

class Program
{
    static async Task Main()
    {
        //var leagues = SkySportsLeagues.GetLeagues();
        var leagues = LivescoreLeagues.GetLeagues();

        foreach (var league in leagues)
        {
            await league.FetchStandingsAsync();
            await league.FetchFixturesAsync();

            var top5 = league.Standings.Take(5).ToList();
            var bottom3 = league.Standings.Skip(league.Standings.Count - 3).ToList();

            Console.WriteLine($"--- {league.Name} ---");
            Console.WriteLine($"{"Team",-40} | {"Pos",-3} | {"Next Opponent",-40} | {"Opp Pos",-6} | {"Bet"}");
            Console.WriteLine(new string('-', 160));

            foreach (var team in bottom3)
            {
                var match = league.Fixtures
                                  .FirstOrDefault(f => f.Home.Contains(team.Name, StringComparison.OrdinalIgnoreCase)
                                                    || f.Away.Contains(team.Name, StringComparison.OrdinalIgnoreCase));

                string nextOpponent = match == null
                    ? "N/A"
                    : (match.Home.Equals(team.Name, StringComparison.OrdinalIgnoreCase)
                        ? match.Away
                        : match.Home);

                var opp = league.Standings.FirstOrDefault(s => s.Name.Equals(nextOpponent, StringComparison.OrdinalIgnoreCase));
                int? oppPos = opp?.Position;
                string bet = (oppPos.HasValue && oppPos.Value <= 5) ? "Yes" : "No";

                Console.WriteLine($"{team.Name,-40} | {team.Position,-3} | {nextOpponent,-40} | {oppPos?.ToString() ?? "N/A",-6} | {bet}");
            }
            Console.WriteLine();
        }
    }
}