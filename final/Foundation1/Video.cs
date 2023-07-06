public class Video {
    
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments;

    public Video(string title, string author, int seconds) {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = new List<Comment>();
    }

    public void SetComment(Comment comments) {
        _comments.Add(comments);
    }

    public int NumberOfComments() {
        return _comments.Count();
    }

    public void VideoDisplay() {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_seconds} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        int i = 1;
        foreach(Comment comment in _comments) {
            Console.Write($"{i}. ");
            comment.CommentDisplay();
            i = i + 1;
        }
        Console.WriteLine("");
    }

}