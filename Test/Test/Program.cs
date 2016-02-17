using System;

namespace Test
{
	class Program
	{
		public static void Main()
		{
			Weapon sword = new Weapon();
			sword.damage = 100;
			sword.magic = 20;
			
			Weapon gun = new Weapon();
			gun.damage = 150;
			gun.magic = 0;
			
			Weapon stuff = new Weapon();
			stuff.damage = 20;
			stuff.magic = 85;
			
			int sword_damage = sword.damageCalculate();
			int gun_damage = gun.damageCalculate();
			int stuff_damage = stuff.damageCalculate();
			
			Console.WriteLine(sword_damage);
			Console.WriteLine(gun_damage);
			Console.WriteLine(stuff_damage);
			Console.ReadKey(true);
		}
	}
	class Weapon
	{
		public int damage,magic;
		
		public int damageCalculate()
		{
			int bossdamage = damage + magic;
			return bossdamage;
		}
	}
}