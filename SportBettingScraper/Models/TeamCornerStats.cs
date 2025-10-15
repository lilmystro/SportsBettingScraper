using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBettingScraper.Models;

public class TeamCornerStats
{
    public required string League { get; set; }
    public required string Team { get; set; }

    public double TotalCorners => TotalCornersFor + TotalCornersAgainst;
    public double TotalCornersFor { get; set; }
    public double TotalCornersAgainst { get; set; }

    public double TotalHomeCorners => HomeCornersFor + HomeCornersAgainst;
    public double HomeCornersFor { get; set; }
    public double HomeCornersAgainst { get; set; }

    public double TotalAwayCorners => AwayCornersFor + AwayCornersAgainst;
    public double AwayCornersFor { get; set; }
    public double AwayCornersAgainst { get; set; }
}
