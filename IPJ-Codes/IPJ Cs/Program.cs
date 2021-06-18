using System;
using System.Collections.Generic;
using System.IO;

class Program
{

	static bool gameOpen = true;
	static void Main(string[] args)
	{
		GamePlay game = new GamePlay();

		while (gameOpen)
		{
			game.Play();
		}
		if (gameOpen == false) {
			Console.WriteLine("Gracias por jugar");
		}
	}

	public static void Exit() {
		gameOpen = false;
	}
}
