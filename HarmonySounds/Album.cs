class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get;}
    
    public int TotalDuration => musics.Sum(m => m.Duration );

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }


    public void ShowAlbumMusics()
    {
        System.Console.WriteLine($"List of Album Musics {Name}\n");
        foreach (var music in musics)
        {
            System.Console.WriteLine($"Music: {music.Name}");
        }
        System.Console.WriteLine($"\nThe Total Durantion of Album is: {TotalDuration}");
    }

}