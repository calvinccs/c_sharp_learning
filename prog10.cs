using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Random numberGen = new Random();

			int numberOFAttempts = 0;
			int attempt = 0;

			while (attempt != 6) {
				attempt = numberGen.Next(1, 7);
				Console.WriteLine("Tom rolled: " + attempt + ".");
				numberOFAttempts++;
			}
			Console.WriteLine("It took Tom " + numberOFAttempts + " attempts to rolls a six!");
			Console.ReadKey();
		}
	}
}

