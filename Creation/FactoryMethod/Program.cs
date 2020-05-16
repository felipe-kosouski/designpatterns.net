using System;
namespace FactoryMethod
{
	public class Program
	{
		public static void Main(string[] args)
		{
			FactoryMethod fm = new FactoryMethod();

			Console.WriteLine("Liu Kang | SubZero | Scorpion");
			Console.WriteLine();

			Console.Write("Choose your Character: ");
			string option = Console.ReadLine();

			ICharacter character = fm.ChooseCharacter(option);
			Console.WriteLine();

			Console.Write("You'll play with: ");
			character.Choosen();

			Console.ReadKey();
		}

	}
}