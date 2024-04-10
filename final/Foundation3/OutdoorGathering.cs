public class OutdoorGathering : Event
{
    protected string _weather;
    protected Address _address;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _address = address;
        _weather = weather;
        
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
        Console.WriteLine("Type of event: Outdoor Gatherings");
        Console.WriteLine($"Expected weather conditions: {_weather}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");

    }

    public void DisplayShortDescription()
    {

        Console.WriteLine("Type of event: Reception");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    
    

    }
}