using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting Letters and Removing Duplicates
namespace Chapter09Assignment05
{
	class Program
	{
		//How many characters to generate
		const int CHARS = 30;

		static void Main(string[] args)
		{
			//Declarations
			List<char> chars = new List<char>();
			Random r = new Random();

			//Header
			Console.WriteLine(" *** Sorting Letters and Removing Duplicates *** ");

			//Populate List with random letters
			for (int x = 0; x < CHARS; x++)
			{
				chars.Add(RandomLetter(r.Next(0, 26)));
			}

			//Output original list
			Console.WriteLine("Character List:");
			foreach (var i in chars)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.WriteLine();

			//a) Use LINQ to sort the list in ascending order.
			Console.WriteLine("Ascending Order:");
			var ascending =
				from c in chars
				orderby c ascending
				select c;
			foreach (var i in ascending)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.WriteLine();

			//b) Use LINQ to sort the list in descending order.
			Console.WriteLine("Descending Order:");
			var descending =
				from c in chars
				orderby c descending
				select c;
			foreach (var i in descending)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.WriteLine();

			//c) Display the List in ascending order with duplicates removed.
			Console.WriteLine("Ascending Order No Dupes:");
			var noDupe =
				from c in chars
				orderby c ascending
				select c;
			foreach (var i in noDupe.Distinct())
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.WriteLine();

			//Spacing
			Console.WriteLine();
		}

		//Generates a random char
		public static char RandomLetter(int rng)
		{
			string alphabet = "abcdefghijklmnopqrstuvwxyz";
			char c = alphabet[rng];
			return c;
		}
	}
}
