using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


    }

       static void DisplayWelcome()

       {
        Console.WriteLine("Welcome to the program!");
       }

       static string PromptUserName()
       {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
       }

       static int PromptUserNumber()
       {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
       }

       static int SquareNumber (int number)
       {
        int square = number*number;
        return square;
       }

       static void DisplayResult(string name, int square)
       {
        Console.WriteLine($"{name}, the square of your number is {square}");
       }
}