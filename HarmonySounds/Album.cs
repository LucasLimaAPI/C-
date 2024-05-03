namespace HarmonySounds
{
    public class Album(string name)
    {
        private readonly List<Music> musics = [];

        public string Name { get; } = name;

        public int TotalDuration => musics.Sum(m => m.Duration);

        public void AddMusic(Music music)
        {
            musics.Add(music);
        }


        public void ShowAlbumMusics()
        {
            Console.WriteLine($"List of Album Musics {Name}\n");
            foreach (var music in musics)
            {
                Console.WriteLine($"Music: {music.Name}");
            }
            Console.WriteLine($"\nThe Total Durantion of Album is: {TotalDuration}");
        }

    }
}