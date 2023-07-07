using System;

class Program
{

    static void DisplayVideos(List<Video> videos)
    {
        foreach (Video v in videos)
        {
            v.DisplayVideo();
            Console.WriteLine();
        }
    
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!\n");
        
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Elephant Gun Annihilates Ballistic Gel", "Slow Mo Guys", 1204);
        Video video2 = new Video("3 mindsets to make you strong", "Darcie", 966);
        Video video3 = new Video("How to Test the Stator on a Motorcycle", "Partzilla", 495);

        video1.CommentsAdd("wadeWilson01", "You guys are like a bunch of school kids in the backyrad with ridicilous toys, please never stop!");
        video1.CommentsAdd("immaNerd", "This video was insane!");
        video1.CommentsAdd("amelia", "I love that Dan\'s impulse before doing something difficult is to take his shirt off.");

        video2.CommentsAdd("limeilii", "Thank you so much for this video I learned a lot!");
        video2.CommentsAdd("nicoletan7056", "Your advice is really insightful!");
        video2.CommentsAdd("jinwenang894", "really needed this, thank you so much for sharing darcie! :)");

        video3.CommentsAdd("tomclark3592", "What do I do if it catches fire?");
        video3.CommentsAdd("claytonfields8017","Thanks for the video.");
        video3.CommentsAdd("stevensapyak", "Great video.");
        video3.CommentsAdd("zeus3358", "Helped me fix the stator in my 2002 Yamaha R1, thanks!");

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        DisplayVideos(_videos);

    }
}

/*
Foundation 1 Design

public class Video
~ Attributes
List<Comment> _comments
string _title
string _author
int _length

~ Constructor(title, author, length)

~ Methods
int CommentsNumber()


public class Comment
~ Attributes
string _userName
string _text

~ Constructor(userName, text)

~ Methods
none

*/