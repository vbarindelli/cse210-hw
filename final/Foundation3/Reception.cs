public class Reception : Event
{
    protected string _rsvp;
    protected Address _address;
    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base (title, description, date, time, address)
    {
        _address = address;
        _rsvp = rsvp;
        
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
        Console.WriteLine("Type of event: Reception");
        Console.WriteLine($"Please, RSVP at {_rsvp}");
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