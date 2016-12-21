using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int numA = 16;
			int numB = 4;

			Console.WriteLine("A is " + numA + ", B is " + numB);
			Console.WriteLine("What is the sum of A and B?");

			int ans = Convert.ToInt32(Console.ReadLine());
			if (ans < numA+numB)
			{
				Console.WriteLine("Too small, try again!");
			}
			else if (ans > numA + numB)
			{
				Console.WriteLine("Too big, try again!");
			}
			else {
				Console.WriteLine("Right, you got it!");
			}
			Console.ReadKey();




		}
	}
}


