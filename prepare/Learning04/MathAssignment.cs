public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string subject, string section, string numbers) : base (name, subject)
    {
        
        _textbookSection = section;
        _problems = numbers;
    
    }

    public string GetHomeworkList()
    {
        string stuff = $"Section {_textbookSection} Problems {_problems}";
        return stuff ;
    }




}