// CLASS

// name
// artist
// duration
// available

class Music
{

    public Music(Band artist, string name)//Constructor By creating this way we can avoid creating an instance of a song without a band
    {
        Name = name;
        Artist = artist;
    }

    public string Name{get; set;} 
    public Band Artist {get;}// tirando metodo de atribuicao set
    public int Duration {get; set;}
    public bool Available{get; set;} //private method security
   // public void AnswerAvailable(bool value)//set
   // {
  //      available = value;
//    }

 //   public bool ReadAvailable()//get
    //{
    //    return available;
 //   } //entregando valor por esse motivo não é um void e sim o valor inserido.

    public string ResumDescription => 
        $"The song {Name} belongs to the band {Artist} "; //Arrowfunction = lambda for simple functions works good.
        // property model "prop", this line take name and artist to send a resum

    //creating a method
    public void ShowDataSheet() // "void" Método que não tem retorno
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Artist: {Artist.Name}");
            System.Console.WriteLine($"Duration: {Duration}");
            
            if (Available)
            {

                System.Console.WriteLine("Available in the Plan Jr");
            }
            else
                {
                    System.Console.WriteLine("Acquire The Plus+ Plan now!!");
                }
        }  
}