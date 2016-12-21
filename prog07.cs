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
					default:
						Console.WriteLine("Wow, you are getting good.");
						break;
				}
						
			}
			else {
				int diff = Math.Abs(answer - (num01 * num02));
				if (diff == 1)
				{
					Console.WriteLine("Close but not the right answer?");
				} else if (diff <= 10) {
					Console.WriteLine("Try harder!");
				} else {
					Console.WriteLine("Come on? it is not even close!");
				}

			}
			Console.ReadKey();
			goto Start;
		}
	}
}

