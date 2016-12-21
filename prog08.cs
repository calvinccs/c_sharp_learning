using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0) {
					Console.WriteLine(i);
				}
			}
			Console.ReadKey();
		}
	}
}

