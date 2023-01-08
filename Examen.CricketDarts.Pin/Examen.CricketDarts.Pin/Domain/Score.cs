namespace Examen.CricketDarts.Pin.Domain;

public class Score
{
    public Player Player { get; set; }

    public int Throw1 { get; set; }
    public int Throw2 { get; set; }
    public int Throw3 { get; set; }

    public int? ScoreAmount { get; set; }
}