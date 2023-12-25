namespace RunnersApi.Models;

public class Activity
{
    public long Id { get; set; }
    public int Distance { get; set; }

    public DateTime DateTime { get; set; }

    public string? Location { get; set; }

    public int Duration { get; set; }
}