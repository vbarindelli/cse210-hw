using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gabev his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his SOn into the world to condemn the world: but that the world through him might be saved.");
      
        string userInput = "";
        bool isAppEnding = false;
        while(!isAppEnding)
        {
            Console.Clear();

            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();  
            
            if(string.IsNullOrWhiteSpace(userInput))
            {
                scripture.HideRandomWords(2);
            }
            
            isAppEnding = userInput.ToLower() == "quit" || scripture.IsCompletelyHidden();
            
        }

        Console.Clear();

        Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        Console.ReadLine();  
         

       
    }
}