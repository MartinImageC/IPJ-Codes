using System;
using System.Collections.Generic;
using System.Text;

public static class Cheats
{
 
    public static void trucos(string Codigo) {
        GamePlay gamePlay = new GamePlay();
        Player player = new Player();
        bool act = false;
        List<string> inputs = new List<string>() {"EarthBound", "BuzzBuzz"};
        for (int i = 0; i < inputs.Count; i++)
        {
            if (Codigo == inputs[i])
            {
                Console.WriteLine("Cheat Activated");
                act = true;
            }
            else {
                Console.WriteLine("Incorrect Code");
                act = false;
            }
        }

        if (act)
        {
            switch (Codigo)
            {
                case "EarthBound":
                    player = player.Inmortal(player);
                    break;
                case "BuzzBuzz":
                    player = player.SpellCaster(player);
                    break;
            }
        }
    }
    

}

