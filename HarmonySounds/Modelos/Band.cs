
namespace HarmonySounds.Modelos;

internal class Band
{
    private List<Album> albuns = new();
    private List<Evaluation> notes = new List<Evaluation>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Media
    {
        get 
        { 
            if (notes.Count == 0) return 0;
            else return  notes.Average(e => e.Note);

        }

    }
    public List<Album> Albuns => albuns;

    public void AddAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AddNotes(Evaluation nota)
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


}