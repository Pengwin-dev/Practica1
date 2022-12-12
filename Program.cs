// See https://aka.ms/new-console-template for more information
using System.Collections;
namespace System
{
	[Flags]
	public enum Foods
	{
		Spaghetti = 0,
		Lasagna = 1,
		Pizza = 2,
		Calzone = 3

	}
	[Flags]
	public enum Beverages
	{

		Soda = 0,
		Wine = 1,
		Beer = 2

	}

	public struct Consumable
	{
		private readonly string name;
		private readonly float price;
		public Consumable(string name, int price)
		{
			this.name = name;
			this.price = price;
		}
		public string getName() { return this.name; }
		public float getPrice() { return this.price; }

	}

	public struct orderUI
	{

		private readonly Queue<Consumable> products;

		public void processing()
		{
			Console.WriteLine("The first 5 orders in queue are being prepared....");
			for (int i = 0; i < 5; i++) { Console.WriteLine(products.Dequeue().getName()); }

		}

		public void showMenu()
        {

			Console.WriteLine("----- Welcome to Pizza Planet, World!-------");

			Console.WriteLine("Here's all the food that we offer:");

			Console.WriteLine(" 1. Spaghetti. $10.99.");
			Console.WriteLine(" 2. Lasagna. $12.99.");
			Console.WriteLine(" 3. Pizza. $8");
			Console.WriteLine(" 4. Calzone. $6");

			Console.WriteLine("Here's all the Beverages that we offer:");

			Console.WriteLine(" Soda $6.5.");
			Console.WriteLine(" Wine. $9.");
			Console.WriteLine(" Beer. $7.5");
			Console.WriteLine(" Calzone. $6");


		}

	}

}

