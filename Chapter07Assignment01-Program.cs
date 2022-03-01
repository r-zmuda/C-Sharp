using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07Assignment01
{
	class Program
	{
		static void Main(string[] args)
		{
			//Enter your number
			getPrime(10000);
		}

		static void getPrime(int x)
		{
			//Declaration
			int count = 0;

			//Header
			Console.WriteLine("*** List of Primes ***");
			Console.WriteLine();

			//Set up array to size x
			bool[] n = new bool[x + 1];

			//Set all bool to true (except 0 and 1 -- not prime)
			for (int index = 2; index <= x; index++)
			{
				n[index] = true;
			}

			//Find primes (Sieve of Eratosthenes)
			for (int index = 2; index <= x; index++)
			{
				if (n[index] == true)
				{
					for (int y = index * 2; y <= x; y += index)
					{
						n[y] = false;
						//Debug
						//Console.WriteLine($"{index} {y}");
					}
				}
			}

			//Print result
			for (int index = 0; index <= x; index++)
			{
				if (n[index] == true)
				{
					Console.WriteLine($"{index}");
					count++;
				}
			}
			Console.WriteLine();
			Console.WriteLine("*** Results ***");
			if (count > 1 || count == 0)
			{
				Console.WriteLine($"Found {count} prime numbers.");
			}
			else
			{
				Console.WriteLine($"Found {count} prime number.");
			}
			if (n[x])
			{
				Console.WriteLine($"In other news, your number, {x}, is prime.");
			}
			else
			{
				Console.WriteLine($"In other news, your number, {x}, is not prime.");
			}
			Console.WriteLine();
		}
	}
}