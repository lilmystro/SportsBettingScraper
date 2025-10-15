using SportBettingScraper.Core;
using SportBettingScraper.Models;

namespace SportBettingScraper.BettingSims
{
    public static class BottomVsTopBets
    {

        public static async Task<List<League>> Run(List<TeamCornerStats> merged)
        {
            
            //var leagues = SkySportsLeagues.GetLeagues();
            var leagues = LivescoreLeagues.GetLeagues(merged);

            foreach (var league in leagues)
            {
                await league.FetchStandingsAsync();
                await league.FetchFixturesAsync();

                var topTeams = league.Standings.Take((int)Math.Floor((double)league.Standings.Count / 4)).ToList();
                var bottomTeams = league.Standings.Skip(league.Standings.Count - (int)Math.Floor((double)league.Standings.Count / 6)).ToList();

                int counter = 0;

                foreach (var team in bottomTeams)
                {
                    var match = league.Fixtures
                                      .FirstOrDefault(f => f.HomeTeam.Contains(team.Name, StringComparison.OrdinalIgnoreCase)
                                                        || f.AwayTeam.Contains(team.Name, StringComparison.OrdinalIgnoreCase));

                    string nextOpponent = match == null
                        ? "N/A"
                        : (match.HomeTeam.Equals(team.Name, StringComparison.OrdinalIgnoreCase)
                            ? match.AwayTeam
                            : match.HomeTeam);

                    var opp = league.Standings.FirstOrDefault(s => s.Name.Equals(nextOpponent, StringComparison.OrdinalIgnoreCase));
                    int? oppPos = opp?.Position;
                    string bet = (oppPos.HasValue && oppPos.Value <= (int)Math.Floor((double)league.Standings.Count / 4)) ? "Yes" : "No";

                    if (bet.Equals("Yes") && counter == 0)
                    {
                        //Console.WriteLine($"--- {league.Name} ---");
                        //Console.WriteLine($"{"Team",-40} | {"Pos",-3} | {"Next Opponent",-40} | {"Opp Pos",-6} | {"Bet"}");
                        //Console.WriteLine(new string('-', 160));

                        counter++;
                    }

                    if (bet.Equals("No"))
                        continue;
                    //Console.WriteLine($"{team.Name,-40} | {team.Position,-3} | {nextOpponent,-40} | {oppPos?.ToString() ?? "N/A",-6} | {bet}");
                }
                //Console.WriteLine();
            }
            return leagues;
        }
    }
}
