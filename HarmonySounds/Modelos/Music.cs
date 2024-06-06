namespace HarmonySounds.Modelos;

internal class Music(Band artist, string name)
{
    public string Name { get; } = name;
    public Band Artist { get; } = artist;
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string DescriptionResum => $"A música {Name} pertence à banda {Artist}";

    public void ShowDataSheet()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (Available)
        {
            Console.WriteLine("Available in the plan jr.");
        } else
        {
            Console.WriteLine("Subscribe the plan Plus+ Now!!!");
        }
    }
}