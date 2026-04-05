class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random rand = new Random();
        this.id = rand.Next(10000, 100000);

        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Risk it all");
        SayaMusicTrack lagu2 = new SayaMusicTrack("About you");

        lagu1.IncreasePlayCount(77);
        lagu1.PrintTrackDetails();
        lagu2.IncreasePlayCount(99);
        lagu2.PrintTrackDetails();
    }
}



