
namespace HarmonySounds.Modelos;

class Band
{
    private List<Album> albuns = new();
    private List<int> notes = new();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Media => notes.Average();
    public List<Album> Albuns => albuns;

    public void AddAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AddNotes(int nota)
    {
        notes.Add(nota);
    }

    public void ShowDiscografy()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
        }
    }

    public static implicit operator Band(List<int> v)
    {
        throw new NotImplementedException();
    }
}