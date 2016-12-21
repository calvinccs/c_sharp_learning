using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int i = 1;
			while (i <= 10) {
				Console.WriteLine(i);
				i += 1;
			}
			Console.ReadKey();
		}
	}
}

