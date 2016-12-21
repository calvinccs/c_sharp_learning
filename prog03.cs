using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Console.WriteLine("How old are you?");
			int age = Convert.ToInt32(Console.ReadLine());
			if (age < 18)
			{
				Console.WriteLine("Too young! Go away!");
			}
			else if (age == 18)
			{
				Console.WriteLine("Okay, you just made it!");
			}
			else {
				Console.WriteLine("Right, you are fine!");
			}
			Console.ReadKey();
		}
	}
}

