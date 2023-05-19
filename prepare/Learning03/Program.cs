using System;

Console.WriteLine("Hello World");

// neymar._name = "Neymar jr.";
// neymar._position = "Forward";
// neymar._jerseyNumber = 10;

Player neymar = new Player("Neymar jr.",10,"Forward");

Player kobe = new Player("Kobe Bryant", 24);

kobe.SetPosition("Shooting Guard");

Team awesomeSauce = new Team("Awesome Sauce");
awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);

awesomeSauce.AddLoss();
awesomeSauce.AddWin();

awesomeSauce.DisplayRoster();
