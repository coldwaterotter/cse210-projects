public class Reference
{
    private int _numBook = 0;
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;


    public Reference()
    {}
    public Reference(string book, int chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public Reference(int numbook, string book, int chapter, int start)
    {
        _numBook = numbook;
        _book = book;
        _chapter = chapter;
        _startVerse = start;
    }

    public Reference(int numbook, string book, int chapter, int start, int end)
    {
        _numBook = numbook;
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }


    public string GiveReference()
    {
        if ((_endVerse == 0) & (_numBook == 0))
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }   

        else if ((_endVerse == 0) & (_numBook != 0))
        {
            return $"{_numBook} {_book} {_chapter}:{_startVerse}";
        }

        else if ((_endVerse != 0) & (_numBook == 0))
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        else 
        {
            return $"{_numBook} {_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        
    }

    public void CreateReference()
    {

    }
 


}