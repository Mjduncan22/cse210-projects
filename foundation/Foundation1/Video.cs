using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private int _numComments;
    private List<Comments> _comments = new List<Comments>();

    public void VideoDetails(string title, string author, int length, List<(string name, string text)> comments)
    {
        _title = title;
        _author = author;
        _length = length;

        foreach (var item in comments)
        {
            var indvcomment = new Comments();
            Comments comment = indvcomment.CommentDetails(item);
            _comments.Add(comment);
        }
    }
    
    public void GetNumComments()
    {
        _numComments = _comments.Count();

    }
    
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        
        Console.WriteLine($"{_numComments} comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.DisplayCommentText()}");
        }
    }
}