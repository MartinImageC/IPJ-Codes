using System;
using System.Collections.Generic;
using System.Text;

class PauseMenu
{
    public void Pause()
    {
        Console.WriteLine("Paused!, press p to get back.");
        char input = Console.ReadKey().KeyChar;

        if (input == 'p')
        {
            Game.GoToGamePlay();
        }
    }
}