using HarmonySounds;

public  class Podcast(string name)
{
    private readonly List<Maraton> maratons = [];
    public string Name {get;} = name;

    public void AddMaraton(Maraton maraton)
    {
        maratons.Add(maraton);
    }
    public void ShowMaratonRelation()
    {
        System.Console.WriteLine($"Maraton Relation {Name}");
        foreach (Maraton maraton in maratons)
        {
            System.Console.WriteLine($"Maraton: {maraton.Name} ({maraton.TotalDuration})");
        }

    }


}