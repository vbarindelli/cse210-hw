public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    public ListingActivity() 
    : base(
        "Listing", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes? ");

    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();

        int myRandomNumber;

        myRandomNumber = rnd.Next(0, _prompts.Count);

        return _prompts[myRandomNumber];
    }
    private List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        List<string> repsonses = new List<string>();
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                repsonses.Add(Console.ReadLine());
                
            }
            return repsonses;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(3);
        
        Console.WriteLine($"You listed {GetListFromUser().Count} items!!");
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner();
        Console.Clear();
    }

   
    
}