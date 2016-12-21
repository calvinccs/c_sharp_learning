using System;
using System.Collections.Generic;

// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			//
			List<int> numbers = new List<int> ();

			numbers.Add(13);
			numbers.Add(4);
			numbers.Add(8);

			//Console.WriteLine(numbers[1]);

			for (int i = 0; i < numbers.Count; i++)
			{
				Console.Write(numbers[i] + ", ");
			}

			Console.WriteLine();
			numbers.RemoveAt(0); //removed the first number

			for (int i = 0; i < numbers.Count; i++)
			{
				Console.Write(numbers[i] + ", ");
			}

			//foreach (string name in names)
			//{
			//	Console.Write(name + ", ");
			//}

			Console.ReadKey();
		}
	}
}

