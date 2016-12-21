using System;
using System.Collections.Generic;

// http://forum.brackeys.com/thread/answer-to-the-challenge-in-how-to-program-in-c-nr-4-2/

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			// multidimensional arrays
			CreateGrid();

			Console.ReadKey();
		}
		public static void CreateGrid()
		{
			int width = 20;
			int height = 20;

			int[][] grid = new int[width][height];
		}
	}
}