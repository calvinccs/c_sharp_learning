using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int result = Add (10, 8);
			if (result > 10)
			{
				Console.WriteLine("Result is larger than 10");
			}
			else 
			{
				Console.WriteLine("Result is smaller than 10 or equal to 10!");
			}
			Console.ReadKey();
		}
		public static int Add(int num01, int num02)
		{
			return num01 + num02;
		}

	}
}

