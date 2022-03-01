using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter05Assignment02
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declarations
			String input;
			int n, temp, digit, sum = 0, exp = 0;

			//Input from user
			Console.WriteLine("*** Binary to Decimal ***");
			Console.WriteLine("Input a binary number (1s and 0s).");
			Console.Write("num: ");
			input = Console.ReadLine();

			//Binary verification
			while (!Regex.IsMatch(input, "^[01]+$"))
			{
				Console.WriteLine("Error: Only 1s and 0s.");
				Console.WriteLine();
				Console.WriteLine("Input a binary number (1s and 0s).");
				Console.Write("num: ");
				input = Console.ReadLine();
			}

			//Verified binary, store in int
			temp = int.Parse(input);
			n = int.Parse(input);

			//Perform conversion
			while (n > 0)
			{
				digit = n % 10;
				sum += digit * (int)Math.Pow(2, exp);
				n = n / 10;
				exp++;
			}

			//Print results
			Console.WriteLine();
			Console.WriteLine("*** Result ***");
			Console.WriteLine($"Binary: {temp}");
			Console.WriteLine($"Decimal: {sum}");
			Console.WriteLine();
			Console.WriteLine("Program finished.");
		}
	}
}
