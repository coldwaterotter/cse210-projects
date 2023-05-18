// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Player neymar = new Player("Neymar jr.", 10, "Forward");

// neymar._name = "Neymar jr.";
// neymar._position = "Forward";
// neymar._jerseyNumber = 10;

Player kobe = new Player("Kobe Bryant", 24);

kobe.SetPosition("Shooting Guard");
neymar.ShowPlayer();

team awesomeSauce = new team("Awesome Sauce");

awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);

awesomeSauce.DisplayRoster();