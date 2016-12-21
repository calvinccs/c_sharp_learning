using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			//ARRAY 
			int[] numbers = new int[5];
			numbers[0] = 12;
			numbers[1] = 3;
			numbers[2] = 5;

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write(numbers[i] + ", ");
			//}

			foreach (int number in numbers)
			{
				Console.Write(number + ", ");
			}

			Console.ReadKey();
		}
	}
}

