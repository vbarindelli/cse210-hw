public class ReflectingActivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _questionsUsed = new List<string>();

    public ReflectingActivity()
    : base(
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        )
    {
        _prompts.Add("Think of a time when you stood up for someone else. ");
        _prompts.Add("Think of a time when you did something really difficult. ");
        _prompts.Add("Think of a time when you helped someone in need. ");
        _prompts.Add("Think of a time when you did something truly selfless. ");


        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }


    private string GetRandomPrompt()
    {
        Random rnd = new Random();

        int myRandomNumber;

        myRandomNumber = rnd.Next(0, _prompts.Count);

        return _prompts[myRandomNumber];
    }



    private string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            _questions.AddRange(_questionsUsed);
            _questionsUsed = new List<string>();
        }
        Random rnd = new Random();

        int myRandomNumber;

        myRandomNumber = rnd.Next(0, _questions.Count);
        string  question = _questions[myRandomNumber];
        _questions.RemoveAt(myRandomNumber);
        _questionsUsed.Add(question);

        return question;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        string userInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Now ponder on each of the following  questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(3);
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write($"> {GetRandomQuestion()} ");
                ShowSpinner();
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner();
        Console.Clear();

    }

}