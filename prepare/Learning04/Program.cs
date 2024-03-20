using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Virginia Haedo", "HomeEc");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Virginia Haedo", "HomeEc","7.3", "18-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WrittingAssignment a3 = new WrittingAssignment("Virginia Haedo", "HomeEc", "The use of chemistry in the preparation of food");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
            
    }
}