public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;
    protected Address _address;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayStandardDetails()
    {

        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    

    }
    public void DisplayFullDetails()
    {
        Console.WriteLine("Type of event: Lecture");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Capacity: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");

    }

    public void DisplayShortDescription()
    {

        Console.WriteLine("Type of event: Lecture");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    
    

    }
}