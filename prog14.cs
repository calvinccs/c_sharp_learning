using System;
// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			//ARRAY 
			string[] names = new string[3]
			{
				"Tom", "Mark", "Bob"
			};

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write(numbers[i] + ", ");
			//}

			foreach (string name in names)
			{
				Console.Write(name + ", ");
			}

			Console.ReadKey();
		}
	}
}

