using SportBettingScraper.BettingSims;
using SportBettingScraper.Core;

class Program
{
    static async Task Main()
    {
        var merged = CornerBetsMerger.GetMergedEntries();

        var leagues = await BottomVsTopBets.Run(merged);
        CornersBets.Run(leagues, merged);
    }
}