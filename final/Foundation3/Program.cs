using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("341 Aragon Ave", "Malaga", "Andalucia");
        Lecture lecture = new Lecture("The impact of nutrition in overall wellbeing", "A fascinating review of how the food we eat impacts not only our physical state, but also our mental health and overall sense of wellbeing", "Jan 14th, 2024", "4:30 p.m.", address, "Florencia Barindelli", 25);
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();

        Address address1 = new Address("123 La Pampa", "Capital Federal", "Buenos Aires");
        Reception reception = new Reception("Dinner Party", "Dinner party at the Library gardens", "April 14th, 2024", "6:30 p.m.", address1, "virginia@gmail.com");
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();

        Address address2 = new Address("123 Winter Grv", "West Jordan", "Utah");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Young Adult Campout", "Come to the campout, we'll have a fire and share snacks", "May 21st, 2024", "6:30 p.m.", address2, "warm, light breeze");
        Console.WriteLine();
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
        outdoorGathering.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
        outdoorGathering.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine();
    }
}