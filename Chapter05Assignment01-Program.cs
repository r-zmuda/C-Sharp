using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05Assignment01
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declarations
			int n = 0, n_rev = 0, temp, digit;

			//Take number from user
			Console.WriteLine("*** Palindrome? ***");
			Console.Write("Enter a positive 5-digit number: ");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine();

			//Verification
			while (!(n > 0 && n.ToString().Length == 5))
			{
				Console.WriteLine($"Your number must be a positive 5 digit number.");
				Console.WriteLine();

				Console.Write("Enter a 5-digit number: ");
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

			//Check if result is the same
			if (n == n_rev)
			{
				Console.WriteLine("*** Result ***");
				Console.WriteLine($"{n} is a palindrome.");
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("*** Result ***");
				Console.WriteLine($"{n} is not a palindrome.");
				Console.WriteLine();
			}
		}
	}
}
