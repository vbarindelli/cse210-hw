using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator promptGenerator = new PromptGenerator();

    public void AddNewPrompt(string newPrompt)
    {
        promptGenerator.AddNewPrompt(newPrompt);
    }

    public Entry CreateEntry()
    {
        Entry entry = new Entry
        {
            _date = DateTime.Now.ToString("dd/MM/yyyy"),
            _promptText = promptGenerator.GetRandomPrompt()
        };
        Console.WriteLine(entry._promptText);
        entry._entryText = Console.ReadLine();
        return entry;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
        }

    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.Write($"Date: {entry._date} - Prompt: {entry._promptText}");
                outputFile.WriteLine($"{entry._entryText}");
            }

        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}