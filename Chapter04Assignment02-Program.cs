using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04Assignment02
{
	class Program
	{
		static void Main(string[] args)
		{
			//Initialize variables
			string fname, lname, gender;
			int year, month, date, height, weight;

			//Accept data from user
			Console.Write("Enter your first name: ");
			fname = Console.ReadLine();
			Console.Write("Enter your last name: ");
			lname = Console.ReadLine();
			Console.Write("Enter your gender: ");
			gender = Console.ReadLine();
			Console.Write("Enter your birth year: ");
			year = int.Parse(Console.ReadLine());
			Console.Write("Enter your birth month: ");
			month = int.Parse(Console.ReadLine());
			Console.Write("Enter your birth date: ");
			date = int.Parse(Console.ReadLine());
			Console.Write("Enter your height (total inches): ");
			height = int.Parse(Console.ReadLine());
			Console.Write("Enter your weight (lbs): ");
			weight = int.Parse(Console.ReadLine());
			Console.WriteLine();

			//Instantiate new health profile object
			HealthProfile hp = new HealthProfile(fname, lname, gender, year, month, date, height, weight);

			//Display completed health profile
			Console.WriteLine("*** HEALTH PROFILE ***");
			Console.WriteLine($"First Name: {hp.FName}");
			Console.WriteLine($"Last Name: {hp.LName}");
			Console.WriteLine($"Gender: {hp.Gender}");
			Console.WriteLine($"Date of Birth: {hp.DOBMonth}/{hp.DOBDay}/{hp.DOBYear}");
			Console.WriteLine($"Age: {hp.calculateAge(hp.DOBYear)} years old");
			Console.WriteLine($"Height: {hp.Height / 12}'{hp.Height % 12}''");
			Console.WriteLine($"Weight: {hp.Weight} lbs.");
			Console.WriteLine($"Maximum Heart Rate: {hp.calculateHRMax(hp.DOBYear)} bpm");
			Console.WriteLine($"Target Heart Rate: {hp.calculateHRTargetLow(hp.DOBYear)} - {hp.calculateHRTargetHigh(hp.DOBYear)} bpm");
			Console.WriteLine($"BMI: {hp.calculateBMI(hp.Height, hp.Weight):F1}");
			Console.WriteLine();

			//Print BMI table
			Console.WriteLine("*** BMI TABLE ***");
			Console.WriteLine("Underweight: Less than 18.5");
			Console.WriteLine("Normal: Between 18.5 and 24.9");
			Console.WriteLine("Overweight: Between 25 and 29.9");
			Console.WriteLine("Obese: Greater than 30");
			Console.WriteLine();

			//Display maximum/target heart rate disclaimer (from book)
			Console.WriteLine("*** NOTE ***");
			Console.WriteLine("These formulas are estimates provided by the AHA.");
			Console.WriteLine("Maximum and target heart rates may vary based on the health, fitness, and gender of the individual.");
			Console.WriteLine("Always consult a physician or qualified health care professional before beginning or modifying an exercise program.");
			Console.WriteLine();

			//Program finished
			Console.WriteLine("Program finished.");
			Console.WriteLine();
		}
	}
}
