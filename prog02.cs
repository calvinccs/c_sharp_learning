using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Start:
			double num01;
			double num02;

			Console.Write("Type a number to be divide: ");
			num01 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Type another number: ");
			num02 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("The result of " + num01 + " divided by " + num02 + " equal to " + num01/num02);
			Console.ReadKey();

			// wait for the user to press a key. Then make empty space and start over
			Console.ReadKey ();
			Console.WriteLine();
			goto Start; //Jumps to "Start:"
		}
	}
}
