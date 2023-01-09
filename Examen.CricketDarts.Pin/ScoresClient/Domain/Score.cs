namespace ScoresClient.Domain;

public class Score
{
    public string Player { get; set; }

    public string Throw1 { get; set; }
    public string Throw2 { get; set; }
    public string Throw3 { get; set; }

    public int? ScoreAmount { get; set; }
}