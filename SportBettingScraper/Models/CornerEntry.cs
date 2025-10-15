namespace SportBettingScraper.Models;
public class CornerEntry
{
    public required string League { get; set; }
    public required string Team { get; set; }
    public double Games { get; set; }   // TG / GA / GH etc
    public double CF { get; set; }      // corners for (average)
    public double CA { get; set; }      // corners against (average)
}
