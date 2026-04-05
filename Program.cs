class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        if (title == null)
            throw new ArgumentException("Judul tidak boleh null");
        if (title.Length > 100)
            throw new ArgumentException("Judul maksimal 100 karakter");
        this.title = title;
        Random rand = new Random();
        this.id = rand.Next(10000, 100000);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0)
            throw new ArgumentException("Tidak boleh negatif");
        if (count > 10000000)
            throw new ArgumentException("Maksimal 10 juta");
        if ((long)playCount + count > int.MaxValue)
            throw new OverflowException("Play count overflow");

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
        try
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Risk it all");
            SayaMusicTrack lagu2 = new SayaMusicTrack("About you");

            for (int i = 0; i < 5; i++)
            {
                lagu1.IncreasePlayCount(10000000);
            }

            lagu1.PrintTrackDetails();
            lagu2.PrintTrackDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}

