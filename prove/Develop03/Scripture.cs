public class Scripture
{
    List<Word> _eachWord = new List<Word>();
    private string _text;
    private Reference _reference;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _text = text;
        string[] allWords = text.Split(" ");
        foreach (string word in allWords)
        {
            Word w = new Word(word);
            _eachWord.Add(w);
        }   
        
    }

public void UnhideWords()
{
    if (IsAllShown() == false)
    {
        int i = 0;
        while (i < 3)
        {
            Random random = new Random();
            int index = random.Next(0,_eachWord.Count());

            if (_eachWord[index].IsHidden() == true)
            {
            _eachWord[index].Show();
            }
            else if ((_eachWord[index].IsHidden() == false))
            {
                while(_eachWord[index].IsHidden() == false)
                {
                    index = random.Next(0,_eachWord.Count());
                }
                _eachWord[index].Show();
            }
            else
            {}
            i ++;
        }
    }
    else
    {}

}

public void HideWords()
{
    int i = 0;
    while (i < 3)
    {
        Random random = new Random();
        int index = random.Next(0,_eachWord.Count());

        if (_eachWord[index].IsHidden() == false)
        {
          _eachWord[index].Hide();
        }
        else if ((_eachWord[index].IsHidden() == true) & (IsComplete() != true))
        {
            while(_eachWord[index].IsHidden() == true)
            {
                index = random.Next(0,_eachWord.Count());
            }
            _eachWord[index].Hide();
        }
        else
        {
        }
        i ++;
    }
}

public void ShowText()
{
    Console.WriteLine(_reference.GiveReference());
    foreach (Word word in _eachWord)
    {
        Console.Write($" {word.GetText()}");
    }
    Console.Write("\n  > ");
}

public bool IsComplete()
{
    bool done = true;
        foreach (Word word in _eachWord)
        {
            if (word.IsHidden() == false)
            {
                done = false;
            }

            else
            {}
            
        }
    return done;
    
}

public bool IsAllShown()
{
    bool allShown = true;
        foreach (Word word in _eachWord)
        {
            if (word.IsHidden() == true)
            {
                allShown = false;
            }

            else
            {}
            
        }
    return allShown;
    
}


}