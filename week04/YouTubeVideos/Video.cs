using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comments> _comments;
    public Video()
    {
        
        _comments = new List<Comments>();
    }


    public void AddComment(string username, string text)
    {
        Comments newComment = new Comments(username, text);
        _comments.Add(newComment);
    }
    public int DisplayNumComments()
    {
        return _comments.Count();
    }
}

