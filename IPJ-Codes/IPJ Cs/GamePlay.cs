using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class GamePlay
{
	public bool goToPause = false;
	private Player player;
	private Inn inn;
	private Tower tower;
	private Balcony balcony;
	public GamePlay()
	{
		Console.WriteLine("---Menu Principal---");
		Console.WriteLine("1.Empezar partida nueva.");
		Console.WriteLine("2.Cargar partida.");
		Console.WriteLine("3.Salir.");
		int answer = Convert.ToInt32(Console.ReadLine());
		Menu(answer);
	}
	public void Menu(int answer)
	{
		switch (answer)
		{
			case 1:
				StartNewGame();
				break;
			case 2:
				LoadGame();
				break;
			case 3:
				Program.Exit();
				break;
		}
	}
	
	public void LoadGame()
	{
		Load();
		inn = new Inn();
	}

	public void StartNewGame()
	{
		player = new Player("Pepe", 100, 20, Location.Inn);
		inn = new Inn();
		tower = new Tower(10);
	}

	public bool Play()
	{
		switch (player.GetLocation())
		{
			case Location.Inn:
				player = inn.Stay(player);
				break;
			case Location.Tower:
				player = tower.StayInside(player);
				break;
			case Location.Balcony: 
				player = balcony.InsideBalcony(player);
				break;
			default:
				return false;
		}	
		return true;
	}


	public void Save()
	{
		Stream save = File.Open("MySave.sav", FileMode.OpenOrCreate);
		BinaryWriter bw = new BinaryWriter(save);
		bw = player.Save(bw);
		bw = tower.Save(bw);
		bw.Close();
		save.Close();
	}

	public void Load()
	{
        try//cosas que generen problemas.
        {
			Stream file = File.Open("MySave.sav", FileMode.Open);

			BinaryReader br = new BinaryReader(file);
			player = new Player();
			br = player.Load(br);
			tower = new Tower();
			br = tower.Load(br);
			br.Close();
			file.Close();
		}
        catch (Exception)
        {
			StartNewGame();
			//Console.WriteLine(error.Message);
            throw;//Informa del error.
        }		

	}

}
