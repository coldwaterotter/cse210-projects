public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string name, string subject)
    {
        _studentName = name;
        _topic = subject;

    }

    public string GetStudentName()
    {
        string name = _studentName;
        return name;
    }
    public string GetSummary()
    {
        string stuff = $"Name: {_studentName} -- Subject: {_topic}";
        return stuff;
    }




}