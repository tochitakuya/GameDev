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
			
			int sword_damage = sword.damageCalculate();
			int gun_damage = gun.damageCalculate();
			
			Console.WriteLine(sword_damage);
			Console.WriteLine(gun_damage);
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