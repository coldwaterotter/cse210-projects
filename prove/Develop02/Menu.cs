public class Menu
{
    private Journal _journal;
    public  Menu(Journal journal)
    {
    _journal = journal;
    
    }


    public void Display()
    {
        string response = "";
        string[] options = {"W", "D", "L", "S", "Q","F"};
        Console.WriteLine("\n\nWelcome to the Journal Program!\n");
        
        while(response != "Q")
        {
            while (options.Contains(response)==false)
            {
                Console.Write("[W]rite Entry\n[D]Display All Entries\n[F]ind Entry by Keyword \n[L]oad \n[S]ave \n[Q]uit\n\n What do you want to do?\n> ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }

            switch (response)
            {
                case "Q":
                    Environment.Exit(0);
                    break;

                case "W":
                    _journal.AddPage();
                    break;

                case "D":
                    _journal.DisplayEntries();
                    break;

                case "F":
                    Console.Write("What keyword would you like to search? \n > ");
                    string keyword = Console.ReadLine() ?? String.Empty;
                    _journal.FindEntry(keyword);
                    break;

                case "L":
                    Console.WriteLine("Please name the file you would like to load: ");
                    string load = Console.ReadLine() ?? String.Empty;
                    _journal.LoadEntries(load);
                    break;

                case "S":
                    Console.WriteLine("Please name the file you would like to save: ");
                    string save = Console.ReadLine() ?? String.Empty;
                    _journal.SaveEntries(save);
                    break;
            }

            response = "";
        }

    }



}