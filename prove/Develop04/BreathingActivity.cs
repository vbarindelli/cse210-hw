public class BreathingActivity : Activity
{
    public BreathingActivity() 
    : base(
        "Breathing", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {}

    public void Run() 
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(7);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
        ShowSpinner();
        Console.Clear();
    }
}