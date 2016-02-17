using System;

namespace Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			Weapon sword = new Weapon();
			sword.damage = 100;
			sword.magic = 20;
			
			int damage = sword.damageCalculate();
			
			Console.WriteLine(damage);
			Console.ReadKey(true);
		}
	}
	class Weapon
	{
		public int damage;
		public int magic;
		
		public int damageCalculate()
		{
			int bossdamage = damage + magic;
			return bossdamage;
		}
	}
}