using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int appendNumber = 9999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");



        while (appendNumber != 0)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            appendNumber = int.Parse(userNumber);
            if (appendNumber != 0)
            {
                numbers.Add(appendNumber);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");

        int smallPos = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallPos)
            {
                smallPos = number;
            }
        }
        Console.WriteLine($"The smallest possitive number is {smallPos}");
        Console.WriteLine("The sorted list is: ");

       
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}