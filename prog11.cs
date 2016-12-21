using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Add(10, 8);
			Console.ReadKey();
		}
		public static void Add(int num01, int num02)
		{
			Console.WriteLine(num01 + num02);
		}
	}
}

