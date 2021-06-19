using System;
using System.Collections.Generic;
using System.Text;

public class Boss
{
	private string name;
	private int maxLife;
	private int life;
	private int maxMana;
	private int mana;

	private int Defense;
	private int MinAttack;
	private int MaxAttack;

	GamePlay game = new GamePlay();

	public Boss(string name, int maxLife, int maxMana, int minAttack, int maxAttack, int Defense)
	{
		this.name = name;
		this.maxLife = maxLife;
		this.life = maxLife;
		this.maxMana = maxMana;
		this.mana = maxMana;
		this.MinAttack = minAttack;
		this.MaxAttack = maxAttack;
		this.Defense = Defense;
	}

	public Player Fight(Player player)
	{
		
		Console.WriteLine("Attack = 1     -    Defend = 2");
		int answer = Convert.ToInt32(Console.ReadLine());
		switch (answer)
		{
			case 1:
				DoDamage(20);
				break;
			case 2:
				Attack(player);
				break;
		}
		return player;
	}
	public Player Attack(Player player)
	{
		Random random = new Random();
		int damage = random.Next(MinAttack, MaxAttack);
		player.DoDamage(damage);
		return player;
	}
	public string GetStatus()
	{
		string status = "";

		status += "Name: " + name + "\n";
		status += "Life: " + life + "\n";

		return status;
	}
	public void DoDamage(int amount)
	{
		int damage = Defense - amount;
		life -= damage;
		if (life <= 0)
		{
			Console.WriteLine("F " + name);
			Win();
		}
	}

	public void Win() {
		Console.WriteLine("Congratulations!!");
		Console.WriteLine("You are the victorius of the tower");
		Console.WriteLine("Now, you can return to your home as the legendary warrior who defeated the tower of a thousand doors.");
		Console.ReadLine();
		Console.Clear();
		game.Play();
	}
}

