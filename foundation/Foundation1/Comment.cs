using System;

public class Comments
{
    private string _name = "";
    private string _text = "";

    public Comments CommentDetails((string name, string text) item)
    {
        return new Comments
        {
            _name = item.name,
            _text = item.text
        };
    }

    public string DisplayCommentText()
    {
        return $"{_name}: '{_text}'";
    }
}