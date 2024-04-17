// Harmony Sounds
string welcomeMessage = "Welcome to HarmonySounds !!"; //Camel Case In String


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
        case 2: Console.WriteLine("You entered the option: "+ selectOptionNumeric );
            break;
        case 3: Console.WriteLine("You entered the option: "+ selectOptionNumeric );
            break;
        case 4: Console.WriteLine("You entered the option: "+ selectOptionNumeric );
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
    Console.WriteLine("Register Bands");
    Console.Write("Enter the name of the band you want to register: ");
    string nameBand = Console.ReadLine()!; //! is called the null-forgiving operator. It tells the compiler that you are certain that the expression to which it is applied will never evaluate to null.
    Console.WriteLine($"The band {nameBand} has been registered"); //$ string interpolation
    Thread.Sleep(2000); //This line of code is often used to introduce a delay in a program's execution
    Console.Clear();
    MenuOptions();
}

LetWelcomeMessage();
MenuOptions();