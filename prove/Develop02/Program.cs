using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string userInput="";
        Journal journal = new Journal();
        while(userInput != "6")
        {           
            switch (userInput)
            { 
                case "1":
                journal.AddEntry(journal.CreateEntry());
                break;
                case "2":
                journal.DisplayAll();
                break;
                case "3":
                Console.WriteLine("What is the filename?");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
                break;
                case "4":
                Console.WriteLine("What is the filename?");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
                break;
                case "5":
                Console.WriteLine("What is the new prompt?");
                string newPrompt = Console.ReadLine();
                journal.AddNewPrompt(newPrompt);
                break;
                case "6":
                default: 
                break;
            }
            userInput = Menu.showMenu();
        }
    }
}

//For the stretch challenge, I added the option to add more prompts to the list.