using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_2_In_Class_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			//Assignment Header
			Console.WriteLine("Ryan Zmuda");
			Console.WriteLine("SOFT 204 C Sharp II");
			Console.WriteLine("In Class C#2 Exercises");

			//Exercise 1
			//Write a program in C# to display the
			//first 10 natural numbers.
			Console.WriteLine("\n*** Exercise 1 ***");
			Console.WriteLine("Write a program in C# to display the");
			Console.WriteLine("first 10 natural numbers.");
			int e1_step = 10; //Desired size
			for (int x = 1; x <= e1_step; x++)
			{
				Console.Write(x + " ");
			}

			//Exercise 2
			//Write a program in C# to display the
			//cube of the number up to given integer.
			Console.WriteLine("\n\n*** Exercise 2 ***");
			Console.WriteLine("Write a program in C# to display the");
			Console.WriteLine("cube of a number up to given integer.");
			int e2_step = 1; //Start at base 1
			int e2_num = 0;
			int e2_cubed = 0;
			bool e2_gotNum = false;
			e2_num = ValidateNumber(e2_gotNum);
			while (e2_step <= e2_num)
			{
				e2_cubed = e2_step * e2_step * e2_step;
				Console.WriteLine($"The cube of {e2_step} is {e2_cubed}.");
				e2_step++;
			}

			//Exercise 3
			//Write a C# program to calculate the
			//factorial of a given number.
			Console.WriteLine("\n*** Exercise 3 ***");
			Console.WriteLine("Write a C# program to calculate the");
			Console.WriteLine("factorial of a given number.");
			int e3_factorial = 1; //Start at base 1
			int e3_num = 0;
			bool e3_gotNum = false;
			e3_num = ValidateNumber(e3_gotNum);
			for (int x = 1; x <= e3_num; x++)
			{
				e3_factorial *= x;
			}
			Console.WriteLine($"The factorial of {e3_num} is {e3_factorial}.");

			//Exercise 4
			//Write a C# program to check whether a
			//given number is a perfect number or not.
			Console.WriteLine("\n*** Exercise 4 ***");
			Console.WriteLine("Write a C# program to check whether a");
			Console.WriteLine("given number is a perfect number or not.");
			int e4_num = 0;
			int e4_sum = 0;
			bool e4_gotNum = false;

			//Validate number
			e4_num = ValidateNumber(e4_gotNum);

			//Output divisors
			Console.Write("Positive Divisors: ");
			for (int x = 1; x < e4_num; x++)
			{
				if (e4_num % x == 0)
				{
					e4_sum += x;
					Console.Write($"{x} ");
				}
			}

			//Output sum
			Console.WriteLine($"\nSum of Divisors: {e4_sum}");

			//Output result
			if (e4_sum == e4_num)
			{
				Console.WriteLine($"So, {e4_num} is a perfect number.");
			}
			else
			{
				Console.WriteLine($"So, {e4_num} is not a perfect number.");
			}

			//Exercise 5
			//Write a program in C# to create a function to calculate
			//the result of raising an integer number to another.
			Console.WriteLine("\n*** Exercise 5 ***");
			Console.WriteLine("Write a program in C# to create a function to calculate");
			Console.WriteLine("the result of raising an integer number to another.");
			int e5_num = 0; //Store the number
			int e5_exp = 0; //Store the exponent
			int e5_result = 0; //Store the result
			bool e5_gotNum = false;
			bool e5_gotExp = false;

			//Validate numbers
			e5_num = ValidateNumber(e5_gotNum);
			e5_exp = ValidateNumber(e5_gotExp);
			e5_result = Exponent(e5_num, e5_exp);

			//Output result
			Console.WriteLine($"Result: {e5_num} ^ {e5_exp} = {e5_result}");

			//End of program
			Console.WriteLine("\nProgram finished.");
		}

		//Function for Exercise 5
		//Return 0 if 0, else calculate exponent
		public static int Exponent(int num, int exp)
		{
			//Handle zero case
			if (exp == 0)
			{
				return 0; //Done
			}
			else
			{
				//Start at base 1
				int result = 1;
				//Exponentialize
				for (int x = 1; x <= exp; x++)
				{
					result *= num;
				}
				return result; //Done
			}
		}

		//Function to validate numbers
		//Returns a positive number, else catch error and try again
		public static int ValidateNumber(bool validator)
		{
			//Setup
			int input = 0;
			Console.Write("Input a positive number: ");
			//Begin validate
			while (validator == false)
			{
				//Try to parse int
				try
				{
					input = Int32.Parse(Console.In.ReadLine());
					//Check for negative
					if (input < 0)
					{
						Console.WriteLine("Error: Negative number.");
						Console.Write("Input a positive number: ");
					}
					else
					{
						validator = true;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Error: Invalid input.");
					Console.Write("Input a positive number: ");
				}
			}
			//Done
			return input;
		}
	}
}
