// Harmony Sounds
string welcomeMessage = "Welcome to HarmonySounds !!"; //Camel Case In String
//List<string> ListBand = new List<string>();//Creating and instance list in c#

Dictionary<string, List<int>> RegisteredBands = new Dictionary <string, List<int>>();//Creating a empty dictionary


void DisplayLogo()// In C#, the void modifier is used to indicate that a function does not return any value. This means that we want to execute a block of code, but we do not expect to receive anything back as a result of the function's execution.
{
    Console.WriteLine(@"
    ＨａｒｍｏｎｙＳｏｕｎｄｓ
    ");//"This is a verbatim string literal. It preserves line breaks and escape characters like \n and \t.
    Console.WriteLine(welcomeMessage);
} 

void MenuOptions()
{
    Console.WriteLine("\nPress 1: Register a new Band");
    Console.WriteLine("Press 2: Show all bands");
    Console.WriteLine("Press 3: Rate a band ");
    Console.WriteLine("Press 4: Display the average of a band ");
    Console.WriteLine("Press -1: Exit");

    Console.WriteLine("\n Select your option:");
    string selectOption = Console.ReadLine()!;//! the statement demonstrates that we are not working with null values.
    int selectOptionNumeric = int.Parse(selectOption);  //int.Parse convert to int

    switch (selectOptionNumeric)
    {
        case 1: RegisterBands();
            break;
        case 2: ShowBandsRegister();
            break;
        case 3: ToAssessBand();
            break;
        case 4: Averagecalc();
            break;
        case -1: Console.WriteLine("You entered the option exit: Good Bye");
            break;
        default: Console.WriteLine("Invalid option");
        break;
    }


}

void RegisterBands()
{
    Console.Clear();
    ShowOptionTitle("Register Bands");
    Console.Write("Enter the name of the band you want to register: ");
    string nameBand = Console.ReadLine()!; //! is called the null-forgiving operator. It tells the compiler that you are certain that the expression to which it is applied will never evaluate to null.
    RegisteredBands.Add(nameBand, new List<int>());
   // ListBand.Add(nameBand);// Registering Bands
    Console.WriteLine($"The band {nameBand} has been registered"); //$ string interpolation
    Thread.Sleep(2000); //This line of code is often used to introduce a delay in a program's execution
    Console.Clear();
    MenuOptions();
}

void ShowBandsRegister()
{
    Console.Clear();
    ShowOptionTitle("Show Bands");

    foreach (string band in RegisteredBands.Keys) //foreach is a looping construct used to iterate over elements in a collection or array, and .Keys return dictionary Keys
    {
        Console.WriteLine("Band: "+ band);
    }

    //for (int i = 0; i < ListBand.Count; i++)
    //{
    //    Console.WriteLine($"Band: {ListBand[i]}");
    //}

    Console.WriteLine("\nEnter any key to return to the menu ");
    Console.ReadKey(); // 
    Console.Clear();
    MenuOptions();
}

void ShowOptionTitle(string title) // Creanting a default design if our consuting any numbers in the app.
{
    int WordsQuant = title.Length;// Length property is commonly used to get the number of elements in an array or the number of characters in a string. It's a built-in property for arrays, strings, and other collections in .NET.
    string asterix  = string.Empty.PadLeft(WordsQuant,'*');
    Console.WriteLine(asterix);
    Console.WriteLine(title);
    Console.WriteLine(asterix + "\n");
}


void Averagecalc()
{
    Console.Clear();
    ShowOptionTitle("Display the average of a band");
    Console.Write($"\nWhich band do you want to see the average? ");
    string nameBand = Console.ReadLine()!;

    if (RegisteredBands.ContainsKey(nameBand))
    {
       List<int> ratings = RegisteredBands[nameBand];
        Console.WriteLine($"The average rating of band {nameBand} is: {ratings.Average()}");
        Console.WriteLine("Enter any key to return to main menu");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();
    } else
    {
        Console.WriteLine($"The band {nameBand} is not found");
        Console.WriteLine("Enter any Key to return the main menu ");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();

    }


}


void ToAssessBand()
{
    //Enter which band you wish evaluate
    // if band exists on dictionary >> to assign note
    // else , return to menu.

    Console.Clear();
    ShowOptionTitle("Evaluate Band");
    Console.Write("Enter the Band if You need to Evaluate: ");
    string nameBand = Console.ReadLine()!;
    if (RegisteredBands.ContainsKey(nameBand))
    {
        Console.WriteLine($"What rating does the band {nameBand} deserve?");
        int rate = int.Parse(Console.ReadLine()!);
        RegisteredBands[nameBand].Add(rate);
        Console.WriteLine($"\nThe Rate {rate} was registered successfully");
        Thread.Sleep(2000); //This function wait 2 seconds 
        Console.Clear(); 
        MenuOptions();
    } else
    {
        Console.WriteLine($"The band {nameBand} is not found");
        Console.WriteLine("Enter any Key to return the main menu ");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();
    }


}

MenuOptions();