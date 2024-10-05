using System.Transactions;

public class Video
{
    // initializes member attributes of _title, _author, and _videoLength. And the member attribute of _comments which is a list that stores comment objects.
    private string _title;
    private string _author;
    private double _videoLength;

    private List<Comment> _comments = new List<Comment>(); 

    // Creates Construtor for the video object that takes arguments for the attributes and populates them.
    public Video(string title, string author, double videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    // Method that formats the video information from the member attributes and prints it to the Console.
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

    // Setter method that add comment objects to the _comments List.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method that prints the number of Comment objects store in the _comments list.
    public void NumberOfComments(List<Comment> comments)
    {
        int count = _comments.Count();

        Console.WriteLine($"Number of Comments: {count}");
    }
}