// Harmony Sounds
string welcomeMessage = "Welcome to HarmonySounds !!"; //Camel Case In String


void LetWelcomeMessage()// In C#, the void modifier is used to indicate that a function does not return any value. This means that we want to execute a block of code, but we do not expect to receive anything back as a result of the function's execution.
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

    if (selectOptionNumeric == 1);
    {
        Console.WriteLine("You entered the option "+ selectOption);
    }


}



LetWelcomeMessage();
MenuOptions();