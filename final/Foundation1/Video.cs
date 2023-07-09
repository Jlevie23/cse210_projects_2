class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine("Title: {0}", Title);
        Console.WriteLine("Author: {0}", Author);
        Console.WriteLine("Length: {0} seconds", Length);
        Console.WriteLine("Number of comments: {0}", GetNumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}