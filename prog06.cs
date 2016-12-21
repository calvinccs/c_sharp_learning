using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
		Start:
			Random numberGenerator = new Random();

			int num01 = numberGenerator.Next(1, 11);
			int num02 = numberGenerator.Next(1, 11);

			Console.WriteLine("What is " + num01 + " times " + num02 + "?");
			int answer = Convert.ToInt32(Console.ReadLine());

			if (answer == num01 * num02)
			{
				int responseIndex = numberGenerator.Next(1, 4);
				switch (responseIndex)
				{
					case 1:
						Console.WriteLine("Well done! Your answer is correct.");
						break;
					case 2:
						Console.WriteLine("Correct!");
						break;
					case 3:
						Console.WriteLine("Wow, you are getting good.");
						break;
				}
						
			}
			else {
				int responseIndex = numberGenerator.Next(1, 4);
				switch (responseIndex)
				{
					case 1:
						Console.WriteLine("Are you even trying?");
						break;
					case 2:
						Console.WriteLine("Incorrect!");
						break;
					case 3:
						Console.WriteLine("Come on?");
						break;
				}

			}
			Console.ReadKey();
			goto Start;
		}
	}
}

