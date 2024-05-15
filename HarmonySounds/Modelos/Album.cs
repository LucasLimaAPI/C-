namespace HarmonySounds.Modelos;

class Album
{
    private readonly List<Music> musics = [];

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => musics.Sum(m => m.Duration);
    public List<Music> Musicas => musics;

    public void AddMusic(Music musica)
    {
        musics.Add(musica);
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