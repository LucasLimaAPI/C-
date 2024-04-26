using System.Data.SqlTypes;

class Band
{
    private List<Album> albums = new List<Album>();

    public Band(string name) // "ctor" constructor call
    {
        Name = name;
    }
 
    public string Name { get;}

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ShowDiscografy()
    {
        System.Console.WriteLine($"Band Discografy {Name}");
        foreach (Album album in albums)// use for loop when you need to iterate a specific number of times or when you need precise control over the loop variable
        {
            System.Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
        }
    }
}