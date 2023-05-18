public class team
{

    private List<Player> _players = new List<Player>();
    // private Player _player1;
    // private Player _player2;
    private string _name;

    public team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _players.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"{_name}");
        foreach (Player player in _players)
        {
            Console.WriteLine(player.ShowPlayer());
        }
    }

}