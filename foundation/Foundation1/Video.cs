using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _videoLength;

    private List<Comment> _comments = new List<Comment>(); 

    public Video(string title, string author, double videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public void Display()
    {
        Console.WriteLine();   
        Console.WriteLine($"Video title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length in seconds: {_videoLength}");
        NumberOfComments(_comments);
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void NumberOfComments(List<Comment> comments)
    {
        int count = _comments.Count();

        Console.WriteLine($"Number of Comments: {count}");
    }
}