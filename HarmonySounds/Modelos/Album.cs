namespace HarmonySounds.Modelos;

internal class Album(string name) : IAvaliavel
{
    private readonly List<Music> musics = [];
    private readonly List< Evaluation> notas = [];

    public string Name { get; } = name;
    public int TotalDuration => musics.Sum(m => m.Duration);
    public List<Music> Musicas => musics;
    
     public double Media
    { 
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(m => m.Note);
        }
    }

    public void AddMusic(Music musica)
    {
        musics.Add(musica);
    }

    public void AdicionarNota(Evaluation nota)
    {
        notas.Add(nota);
    }

    public void ShowAlbumMusic()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {TotalDuration}");
    }
}