public class Word
{
    private bool _hidden = false;
    private string _word;
    public Word(string text)
    {
       _word = text;
       //_hidden = false;
    }

    //privacy returntype methodname(arguments)

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        if (_hidden == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
        

    }

    public string GetText()
    {
        if (_hidden == false)
        {
            return _word;
        }

        else
        {
            string hiddenWord = "";

            foreach (char letter in _word)
            {
                if ((letter != '.') || (letter != '!') || (letter != '?') || (letter != ',') || (letter != ':') || (letter != ';'))
                {
                    hiddenWord += "_";
                }
                else
                {
                    hiddenWord += letter;
                }
            }
            return hiddenWord;
           

        }

    }
}