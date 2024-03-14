public static class Menu
{
    
    public static string showMenu()
    {
        Console.WriteLine("Please, select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Add Prompt");
        Console.WriteLine("6. Quit");
        
        Console.Write("What would you like to do? ");
        string userChoice = Console.ReadLine();

        return userChoice;
    }
}