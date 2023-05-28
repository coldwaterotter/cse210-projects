using System;

class Program
{
// 3 Nephi 5:13
// 13 Behold, I am a disciple of Jesus Christ, the Son of God. I have been acalled of him to declare his word among his people, that they might have everlasting life.

// Alma 5
//50 Yea, thus saith the Spirit: Repent, all ye ends of the earth, for the kingdom of heaven is soon at hand; yea, the Son of God cometh in his aglory, in his might, majesty, power, and dominion. Yea, my beloved brethren, I say unto you, that the Spirit saith: Behold the glory of the bKing of all the earth; and also the King of heaven shall very soon shine forth among all the children of men.
//51 And also the Spirit saith unto me, yea, crieth unto me with a mighty voice, saying: Go forth and say unto this people—Repent, for except ye repent ye can in nowise inherit the akingdom of bheaven.
    static void Main(string[] args)
    {
        Reference _reference = new Reference(3,"Nephi",5,13);
        Scripture _scripture = new Scripture("Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.", _reference);
        string quit = "";
        while (quit != "QUIT")
        {
            Console.Clear();
            Console.WriteLine("\n Hello, Welcome to the Scripture Memorizer Program!\n");
            Console.WriteLine(" -- Press [Enter] or [h] to hide words\n -- Press [u] to unhide words\n -- Type \"quit\" to exit the program\n\n");
            _scripture.ShowText();
            
            string response = Console.ReadLine() ?? String.Empty;
            response = response.ToUpper();
            if ((response == "QUIT") || (_scripture.IsComplete() == true))
            {
                quit = "QUIT";
            }
            else if ((response == "U"))
            {
                _scripture.UnhideWords();
            }
            else if ((response == "H") || (response == ""))
            {
                _scripture.HideWords();
            }
                        
            Console.Clear();
        }

        Environment.Exit(0);
    }
}

/*
Scripture - Keeps track of the reference and the text of the scripture.
 Can hide words and get the rendered display of the text.
 -- Hide Words
 -- Get Rendered Text
 -- Is Completely Hidden
Reference - Keeps track of the book, chapter, and verse information.
 -- 
 -- 
Word - Keeps track of a single word and whether it is shown or hidden.
 -- Hide
 -- Show
 -- Is Hidden
 -- Get Rendered Text
 -- 
 
*/