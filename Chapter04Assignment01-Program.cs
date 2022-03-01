using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04Assignment01
{
   class EmployeeTest
   {
		static void Main()
		{
			Employee empA = new Employee("Bob", "Smith", 2500);
			Employee empB = new Employee("Jessica", "Ross", 2000);

			Console.WriteLine("*** Employee List ***");
			Console.WriteLine($"{empA.FName} {empA.LName} earns {empA.Salary.ToString("C2")} per month.");
			Console.WriteLine($"{empB.FName} {empB.LName} earns {empB.Salary.ToString("C2")} per month.");
			Console.WriteLine();

			Console.WriteLine("*** Employee List: Annual ***");
			Console.WriteLine($"{empA.FName} {empA.LName} earns {(empA.Salary*12).ToString("C2")} annually.");
			Console.WriteLine($"{empB.FName} {empB.LName} earns {(empB.Salary*12).ToString("C2")} annually.");
			Console.WriteLine();

			Console.WriteLine("*** Announcement ***");
			Console.WriteLine("Administration is feeling generous today.");
			Console.WriteLine("All employees qualify for a 10% raise effective immediately.");
			Console.WriteLine();

			empA.Salary = Decimal.Multiply(empA.Salary, 1.1m);
			empB.Salary = Decimal.Multiply(empB.Salary, 1.1m);

			Console.WriteLine("*** Employee List: Annual ***");
			Console.WriteLine($"{empA.FName} {empA.LName} now earns {(empA.Salary*12).ToString("C2")} annually.");
			Console.WriteLine($"{empB.FName} {empB.LName} now earns {(empB.Salary*12).ToString("C2")} annually.");
			Console.WriteLine();
		}
   }
}
