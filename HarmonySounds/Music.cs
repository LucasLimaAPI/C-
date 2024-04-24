// CLASS

// name
// artist
// duration
// available

class Music
{
    public string Name{get; set;} 
    public string Artist {get; set;}
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
            System.Console.WriteLine($"Artist: {Artist}");
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