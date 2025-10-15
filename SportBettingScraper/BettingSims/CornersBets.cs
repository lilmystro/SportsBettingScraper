using CsvHelper;
using CsvHelper.Configuration;
using SportBettingScraper.Core;
using SportBettingScraper.Models;
using System.Formats.Asn1;
using System.Globalization;

namespace SportBettingScraper.BettingSims;

public class CornersBets
{

    public static void Run(List<League> leagues, List<TeamCornerStats> merged)
    {
        //LeagueCornersScraper.PrintLeagueTables(merged);

        LeagueCornersScraper.PrintLowCornerBets(leagues, merged);
    }
}
