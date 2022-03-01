using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//"Duplicate Word Removal"
namespace Chapter09Assignment04
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declarations
			char[] delimiters = { ' ', ',', '.', ':', '!', '?', '\t' };

			//Accept input, put to lowercase
			Console.WriteLine(" *** Duplicate Word Removal *** ");
			Console.Write("Please input sentence: ");
			string input = Console.ReadLine();
			string lower = input.ToLower();
			Console.WriteLine();

			//Split using delimiters, remove empty entries
			string[] words = lower.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);
			
			//Remove duplicates from words, sort
			string[] distinct = words.Distinct().ToArray();
			Array.Sort(distinct);

			//Output distinct
			Console.WriteLine("Words Sorted:");
			foreach (var i in distinct)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine();
		}
	}
}
