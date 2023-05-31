public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string subject, string title) : base(name, subject)
    {
       _title = title;
    }

    public string GetWritingInformation()
    {
        Assignment name = new Assignment("Mary Waters", "European History");
        string tempName = name.GetStudentName();
        string stuff = $"{_title} by {_studentName}";
        string stuff2 = $"{_title} by {tempName}";
        return stuff ;
    }
}