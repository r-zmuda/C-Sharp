using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06Assignment01
{
	class Program
	{
		//Number of stairs to display
		private const int STAIRS = 4;
		//Constant for width of stairs (do not change value -- not supported)
		private const int WIDTH = 5;
		static void Main(string[] args)
		{
			//Build a number of stairs based on the value stored in STAIRS.
			for (int x = 1; x <= STAIRS; x++)
			{
				//Line 1 Output
				for (int spaces = 1; spaces <= STAIRS * WIDTH - WIDTH * x; spaces++)
				{
					Console.Write(" ");
				}
				Console.Write("  O  ******");
				for (int spaces = 1; spaces <= x * WIDTH - WIDTH; spaces++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("$");

				//Line 2 Output
				for (int spaces = 1; spaces <= STAIRS * WIDTH - WIDTH * x; spaces++)
				{
					Console.Write(" ");
				}
				Console.Write(" /|\\ *");
				for (int spaces = 1; spaces <= x * WIDTH; spaces++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("$");

				//Line 3 Output
				for (int spaces = 1; spaces <= STAIRS * WIDTH - WIDTH * x; spaces++)
				{
					Console.Write(" ");
				}
				Console.Write(" / \\ *");
				for (int spaces = 1; spaces <= x * WIDTH; spaces++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("$");
			}
			//Print a row of % as the base of the staircase.
			for (int bottom = 1; bottom <= STAIRS * WIDTH + 7; bottom++)
			{
				Console.Write("%");
			}
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}
