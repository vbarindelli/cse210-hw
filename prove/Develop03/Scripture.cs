using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split();
        _words = new List<Word>();

        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0; i < numberToHide; i++)
        {
            Random rnd = new Random();
            int myRandomNumber;
            myRandomNumber = rnd.Next(0, _words.Count);
            while (_words[myRandomNumber].IsHidden() && !this.IsCompletelyHidden())
            {
                myRandomNumber = rnd.Next(0, _words.Count);
            }
            _words[myRandomNumber].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayVerse = "";

    

        foreach(Word word in _words)
        {
            if (word.IsHidden())
            {
                string replaceChar = ConvertToChar(word.GetDisplayText(), '_');
                displayVerse = $"{displayVerse} {replaceChar}";
            }
            else    
            {
                displayVerse = $"{displayVerse} {word.GetDisplayText()}";
            }
        }

        return displayVerse;
    }
//https://stackoverflow.com/questions/21644658/how-to-use-stringbuilder-wisely
    private string ConvertToChar(string text, char replaceChar)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            stringBuilder.Append(replaceChar);
        }
        return stringBuilder.ToString();
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
