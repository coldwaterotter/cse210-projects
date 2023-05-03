public class Resume
{
    //Attributes
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Constructor
    public Resume()
    {}

    //Methods (functions)
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine("Jobs: ");
        foreach (Job j in _jobs)
        {
            j.DisplayJob();
        }
    }

}