public class Video
{

List<Comment> _comments = new List<Comment>();
string _title;
string _author;
int _length;
public Video(string title, string author, int length)
{
    _title = title;
    _author = author;
    _length = length;
    
}

public void CommentsAdd(string user, string comment)
{
    Comment commentText = new Comment(user, comment);
    _comments.Add(commentText);
}
public int CommentsNumber()
{
    int increment = 0;
    foreach (Comment c in _comments)
    {
        increment += 1;
    }
    return increment;
}

public void CommentsDisplay()
{
    int i = 0;
    
    while (i < CommentsNumber())
    {
        
        Console.Write($"{i+1}. ");
        _comments[i].Displaytext();
        i ++;
        Console.WriteLine();
    }
}

public void DisplayVideo()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length (seconds): {_length}");
    Console.WriteLine($"There are {CommentsNumber()} comments on this video.\n");
    
    CommentsDisplay();
    //Thread.Sleep(2000);

}


}