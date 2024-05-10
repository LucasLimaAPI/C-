namespace HarmonySounds
{
    public class Maraton(string name)
    {
        private readonly List<Episode> episodes = [];

        public string Name { get; } = name;
        public int TotalDuration => episodes.Sum(e => e.Duration);

        public void AddEps(Episode episode)
        {
            episodes.Add(episode);
        }

        public void ShowMaratonEps()
        {
            Console.WriteLine($"\nList of Maraton Episodes: {Name}\n");
            foreach (var episode in episodes)
            {
                Console.WriteLine($"Episode: {episode.Name}");
            }
            Console.WriteLine($"\nThe Total Duration of Maraton is: {TotalDuration}");
        }
    }
}