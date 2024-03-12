public class PromptGenerator
{

    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        LoadPromptFromFile();
        if (_prompts.Count == 0)
        {
            _prompts.Add("Who was the most interesting person I interacted with today? ");
            _prompts.Add("What was the best part of my day? ");
            _prompts.Add("How did I see the hand of the Lord in my life today? ");
            _prompts.Add("What was the strongest emotion I felt today? ");
            _prompts.Add("If I had one thing I could do over today, what would it be? ");
            _prompts.Add("How did I help someone else today? ");
            _prompts.Add("Describe something you did right today: ");
            _prompts.Add("Describe something you want to achieve tomorrow: ");
        }
    }

    public void AddNewPrompt(string newPrompt)
    {
        _prompts.Add(newPrompt);
        SavePromptsToFile();
    }


//I got the code for the random prompt generator from stackoverflow. I figured how to do it knowing the number of prompts and using
// the random generator from the magic number game we did in week 1, but I didn't understand how to do it without knowing that, so I found the below code
//the following link https://stackoverflow.com/questions/74538018/how-can-i-generate-a-random-string-out-of-a-pre-prepared-list-of-strings-in-c

    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        int myRandomNumber;

        myRandomNumber = rnd.Next(0, _prompts.Count);

        return _prompts[myRandomNumber];
    }

    public void SavePromptsToFile()
    {
        using (StreamWriter outputFile = new StreamWriter("prompts.txt"))
        {
            foreach (string prompt in _prompts)
            {
                outputFile.WriteLine(prompt);
            }

        }
    }

    public void LoadPromptFromFile()
    {
        string[] lines = File.ReadAllLines("prompts.txt");

        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }
}