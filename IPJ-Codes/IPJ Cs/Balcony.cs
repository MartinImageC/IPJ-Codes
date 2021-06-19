using System;
using System.Collections.Generic;
using System.Text;


class Balcony
{
    enum Options { Fight, Leave, Error }

    private Boss boss = new Boss("Gygas", 200, 999, 35, 80, 50);
    private Options option;
    
    public Player InsideBalcony(Player player)
    {
        Console.WriteLine("You have reached The Balcony");
        Console.WriteLine("And now The Ultimate Challenge");
        boss.GetStatus();
        Console.WriteLine("Leave = 0    -    Fight = 1");
        switch (option)
        {
            case Options.Fight:
                player = boss.Fight(player);
                break;
            case Options.Leave:
                player = Leave(player);
                break;
        }
        return player;
    }

    public Player Leave(Player player)
    {
        player.GoToInn();
        return player;
    }
}