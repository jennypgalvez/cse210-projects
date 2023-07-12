class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> comments;

    public Video(string title, string author, double length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine($"Number of Comments: " + GetNumberOfComments());
        Console.WriteLine($"---Comments---");

        foreach (Comment comment in comments)
        {
            Console.WriteLine($"- Name: {comment._commenterName}");
            Console.WriteLine($"- Text: {comment._commentText}");
        }
        
        Console.WriteLine();
    }
}
