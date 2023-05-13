using System.IO; 

public class Journal
{
    List<Entry> _pages = new List<Entry>();
    Entry _entry = new Entry();
    private string _load;
    private string _save;

    public Journal()
    {
    }

    public void AddPage()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($" \n{dateText}");

        Prompt randomprompt = new Prompt();
        string prompt = randomprompt.GetRandomPrompt();
        Console.WriteLine($"{prompt} \n");

        Console.Write("Please enter your text: \n > ");
        string text = Console.ReadLine() ?? String.Empty;
        Console.WriteLine();

        Entry createPage = new Entry();
        createPage._date = dateText;
        createPage._prompt = prompt;
        createPage._text = text;
        

        _pages.Add(createPage);
    }

    private void NicePrint(string item)
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("-----------------------");
    }

    public void DisplayEntries()
    {
        foreach (Entry i in _pages)
        {
            NicePrint(i.GetEntry());

        }
    }

    public void FindEntry(string keyword)
    {
        foreach (Entry entry in _pages)
        {
            if (entry.HasKeyword(keyword))
            {
                NicePrint(entry.GetEntry());
            }
        }

    }

    public void SaveEntries(string save)
    {
        string fileName = save;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry line in _pages)

            outputFile.WriteLine($"{line._date}|{line._prompt}|{line._text}");
        }

    }

    public void LoadEntries(string load)
    {
        string filename = load;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string loadfile = parts[0];

            Entry createPage = new Entry();
            createPage._date = parts[0];
            createPage._prompt = parts[1];
            createPage._text = parts[2];

            _pages.Add(createPage);
        }

    }

    





}