public class Comment
{
    // Initializes member attributes of _commenterName and _comment.
    private string _commenterName;
    private string _comment;

    // Creates a Constructor for the Comment class
    public Comment()
    {

    }

    // Creates a Constructor for the comment class that takes two arguments and uses them to populate the member attributes.
    public Comment(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }

    // Creates a Method that Prints a formatted string containing the Commenters name and the comment to the Console.
    public void Display()
    {
        Console.WriteLine($"{_commenterName}: {_comment}");
    }
}