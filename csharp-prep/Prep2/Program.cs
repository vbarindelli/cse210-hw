using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        string letter = ("");
        int lastDigit = grade % 10;
        string sign = ("");

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80) 
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (grade < 90 && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (grade > 60 && lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Keep up the hard work and you'll make it next time.");
        }

    }
}