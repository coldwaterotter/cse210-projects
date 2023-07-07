public class Comment 
{
string _userName;
string _commentText;

public Comment()
{

}
public Comment(string userName, string text)
{
    _userName = userName;
    _commentText = text;
}

public void Displaytext()
{
    Console.WriteLine($"User: {_userName}");
    Console.WriteLine($"Comment: {_commentText}");
    
}



}