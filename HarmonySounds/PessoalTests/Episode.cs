namespace HarmonySounds
{
    public sealed class Episode(Podcast artist, string name)
    {
        public string Name { get; set; } = name;
        public Podcast Artist { get; } = artist;// tirando metodo de atribuicao set
        public int Duration { get; set; }
        public bool Available { get; set; }
        public string ResumDescription => $"The Episode {Name} belongs to the Podcast {Artist} "; //Arrowfunction = lambda for simple functions works good.
                                                                                                  // property model "prop", this line take name and artist to send a resum

        //creating a method
        public void ShowEpInfo() // "void" Método que não tem retorno
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Duration: {Duration}");

            if (Available)
            {

                Console.WriteLine("Available in the Plan Jr");
            }
            else
            {
                Console.WriteLine("Acquire The Plus+ Plan now!!");
            }
        }
    }
}
