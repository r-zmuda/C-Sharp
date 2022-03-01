using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07Assignment03
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declarations
			int a, b, r;

			//Accept input
			Console.WriteLine("*** GCF ***");
			Console.Write("Enter first number: ");
			a = int.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine();

			//Calculate GCF (Euclidean algorithm)
			while (b != 0)
			{
				r = a % b;
				a = b;
				b = r;
			}

			//Print result
			Console.WriteLine("*** Result ***");
			Console.WriteLine($"The GCF is {a}.");
			Console.WriteLine();

		}
	}
}