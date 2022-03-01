using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08Assignment01
{
	class Program
	{
		//Number of rolls
		const int ROLLS = 36000;

		static void Main(string[] args)
		{
			//Declarations
			var freq = new int[13];
			var rand = new Random();

			//Roll 2 dice n times
			for (int n = 1; n <= ROLLS; n++)
			{
				int roll1 = rand.Next(1, 7);
				int roll2 = rand.Next(1, 7);
				int sum = roll1 + roll2;
				freq[sum]++;
			}

			//Output table
			Console.WriteLine("*** Dice Rolling ***");
			Console.WriteLine();
			Console.WriteLine($"{"Result"}{"Count",8}");
			for (var total = 2; total < freq.Length; total++)
			{
				Console.WriteLine($"{total,2}{freq[total],12}");
			}
		}
	}
}
