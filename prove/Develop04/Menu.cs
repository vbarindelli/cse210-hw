public static class Menu
{
    
    public static string showMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
    
        
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();

        return userChoice;
    }
}