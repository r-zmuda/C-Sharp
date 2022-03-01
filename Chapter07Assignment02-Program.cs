using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07Assignment02
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declarations
			int n = 0, n_rev = 0, temp, digit;

			//Take number from user
			Console.WriteLine("*** Reverse ***");
			Console.Write("Enter a positive number: ");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine();

			//Verification
			while (!(n > 0))
			{
				Console.WriteLine($"Your number must be positive.");
				Console.WriteLine();

				Console.Write("Enter a positive number: ");
				n = int.Parse(Console.ReadLine());
				Console.WriteLine();
			}

			//Keep copy of n
			temp = n;

			//Flip digits around
			while (temp > 0)
			{
				digit = temp % 10;
				n_rev = (n_rev * 10) + digit;
				temp = temp / 10;
			}

			//Print result
			Console.WriteLine("*** Result ***");
			Console.WriteLine($"Reversed: {n_rev}");
			Console.WriteLine($"Your number was {n}.");
			Console.WriteLine();
		}
	}
}
