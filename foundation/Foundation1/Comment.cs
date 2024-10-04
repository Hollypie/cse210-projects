public class Comment
{
    private string _commenterName;
    private string _comment;

    public Comment()
    {

    }
    public Comment(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }
    public void Display()
    {
        Console.WriteLine($"{_commenterName}: {_comment}");
    }
}