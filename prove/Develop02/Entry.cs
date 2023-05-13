public class Entry
{
    List<string> _response = new List<string>();
    public string _date;
    public string _text;
    public string _prompt;


    public Entry()
    {

    }

    public string GetEntry()
    {
        
        return $"{_date}\n{_prompt}\n\n{_text}";
    }

    public bool HasKeyword(string key)
    {
        if (_text.ToUpper().Contains(key.ToUpper()))
        {
            return true;
        }
        return false;

    }
    
    









}