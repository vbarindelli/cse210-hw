public class Activity
{

    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
       

        _name = name;
        _description = description;
        DisplayStartingMessage();
        _duration = PromptUserDuration();
    }

    public void DisplayStartingMessage()
    {

        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

    }

    static int PromptUserDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        return userDuration;
    }

    public void DisplayEndingMessage()
    {

        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
    }
    
    public void ShowSpinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");
                Thread.Sleep(1000);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        int i = seconds;
        for (i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}