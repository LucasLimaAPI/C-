// CLASS

// name
// artist
// duration
// available

class Music
{
    public string name; 
    public string artist;
    public int duration;
    public bool available; 

    //creating a method
    public void ShowDataSheet() // "void" Método que não tem retorno
        {
            System.Console.WriteLine($"Name: {name}");
            System.Console.WriteLine($"Artist: {artist}");
            System.Console.WriteLine($"Duration: {duration}");
            
            if (available)
            {

                System.Console.WriteLine("Available in the Plan Jr");
            }
            else
                {
                    System.Console.WriteLine("Acquire The Plus+ Plan now!!");
                }
        }  
}