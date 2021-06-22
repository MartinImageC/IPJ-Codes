using System;
using System.Collections.Generic;
using System.Text;

public static class Cheats
{
    enum Etapas {Menu, Inn, Tower, Balcony}
    public static void trucos(int a) {
        GamePlay gamePlay = new GamePlay();
        Player player = new Player();
        bool act = false;
        List<string> inputs = new List<string>() {"EarthBound", "BuzzBuzz","Mrsaturn"};
        Console.WriteLine("Menu de Trucos: ");
        Console.WriteLine("1.Ver lista de trucos.");
        Console.WriteLine("2.Ingresar un codigo.");
        Console.WriteLine("3.Volver al menu.");
        int answer = Convert.ToInt32(Console.ReadLine());
        switch (answer) {
            case 1:
                for (int i = 0; i < inputs.Count; i++)
                {
                    Console.WriteLine(inputs[i]);
                }
                break;
            case 2:
                string Codigo = Console.ReadLine();
                for (int i = 0; i < inputs.Count; i++)
                {
                    if (Codigo == inputs[i])
                    {
                        Console.WriteLine("Cheat Activated");
                        act = true;
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
                                case "Mrsaturn":
                                    player = player.Greedier(player);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Code");
                        act = false;
                    }
                }
                break;
            case 3:
                break;
        }

        Etapas phases;
        phases = (Etapas)a;
        switch (phases) {
            case Etapas.Menu:
                gamePlay.Play();
                break;
            case Etapas.Inn:
                player.GoToInn();
                break;
            case Etapas.Tower:
                player.GoToTower();
                break;
            case Etapas.Balcony:
                player.GoToLastFloor();
                break;
        }
    }   

}

