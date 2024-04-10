using System.Runtime.InteropServices.Marshalling;

public class Video
{

    public List<Comment> _comments = new List<Comment>();
    public string _title;
    public string _author;
    public int _lenght;

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lenght = length;
    }

    public void commentsTracking()
    {
        int i = 0;   
        
        foreach (Comment comment in _comments)
        {
            i++;

        }

        Console.WriteLine($"Number of Comments: {i}");
        
    }

}