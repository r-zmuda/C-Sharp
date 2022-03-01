using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Savings-Account Class
Create the class SavingsAccount. Use the static read-write property
AnnualInterestRate to store the annual interest rate for all account
holders. Each object of the class contains a property SavingsBalance,
indicating the amount the saver currently has on deposit. Provide method
CalculateMonthlyInterest to calculate the monthly interest by multiplying
the SavingsBalance by AnnualInterestRate divided by 12 -- this interest should
be added to SavingsBalance. Write an app to test class SavingsAccount.
Create two SavingsAccount objects saver1 and saver2, with balances of
$2000.00 and $3000.00, respectively. Set AnnualInterestRate to 4%,
then calculate the monthly interest and display the new balances for
both savers. Then set the AnnualInterestRate to 5%, calculate the
next month's interest and display the new balances for both savers.
*/

namespace Chapter10Assignment05
{
	class Program
	{
		static void Main(string[] args)
		{
			//Header
			Console.WriteLine(" *** Savings-Account Class ***");
			Console.WriteLine();

			//Make SavingsAccounts
			SavingsAccount saver1 = new SavingsAccount(2000.00m);
			SavingsAccount saver2 = new SavingsAccount(3000.00m);

			//Output starting balances
			Console.WriteLine("Initial Balances:");
			Console.WriteLine($"saver1.SavingsBalance: {saver1.SavingsBalance:C2}");
			Console.WriteLine($"saver2.SavingsBalance: {saver2.SavingsBalance:C2}");
			Console.WriteLine();

			//Set annual interest rate to 4%, calculate monthly interest
			Console.WriteLine("AnnualInterestRate = 4%");
			SavingsAccount.AnnualInterestRate = 4;
			saver1.CalculateMonthlyInterest();
			saver2.CalculateMonthlyInterest();

			//Output updated balances
			Console.WriteLine("CalculateMonthlyInterest():");
			Console.WriteLine($"saver1.SavingsBalance: {saver1.SavingsBalance:C2}");
			Console.WriteLine($"saver2.SavingsBalance: {saver2.SavingsBalance:C2}");
			Console.WriteLine();

			//Set annual interest rate to 5%, calculate monthly interest
			Console.WriteLine("AnnualInterestRate = 5%");
			SavingsAccount.AnnualInterestRate = 5;
			saver1.CalculateMonthlyInterest();
			saver2.CalculateMonthlyInterest();

			//Output updated balances
			Console.WriteLine("CalculateMonthlyInterest():");
			Console.WriteLine($"saver1.SavingsBalance: {saver1.SavingsBalance:C2}");
			Console.WriteLine($"saver2.SavingsBalance: {saver2.SavingsBalance:C2}");
			Console.WriteLine();
		}
	}
}
