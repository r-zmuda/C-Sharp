using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Assignment09
{
	class Program
	{
		static void Main(string[] args)
		{
			//Header
			Console.WriteLine(" *** Account Inheritance Hierarchy ***");
			Console.WriteLine();

			//Make Accounts
			Account account1 = new Account(2000.00m);
			SavingsAccount saver1 = new SavingsAccount(5000.00m, 4.5m);
			CheckingAccount checking1 = new CheckingAccount(500.00m, 1.50m);
			Console.WriteLine("** Initial Balances:");
			Console.WriteLine($"account1.Balance: {account1.Balance:C2}");
			Console.WriteLine($"saver1.Balance: {saver1.Balance:C2}");
			Console.WriteLine($"saver1.AnnualInterestRate: {saver1.AnnualInterestRate}%");
			Console.WriteLine($"checking1.Balance: {checking1.Balance:C2}");
			Console.WriteLine($"checking1.Fee: {checking1.Fee:C2}");

			//Test Account Credit(n) method
			Console.WriteLine("\n** Credit account1 $1,000.00.");
			account1.Credit(1000.00m);
			Console.WriteLine($"account1.Balance: {account1.Balance:C2}");

			//Test Account Debit(n) method
			Console.WriteLine("\n** Debit account1 $5,000.00.");
			account1.Debit(5000.00m);
			Console.WriteLine($"account1.Balance: {account1.Balance:C2}");

			//Test SavingsAccount CalculateInterest() method
			Console.WriteLine($"\n** CalculateInterest() Month 1:");
			Console.WriteLine($"Credit saver1 {saver1.CalculateInterest():C2} interest.");
			Console.WriteLine($"saver1.Balance: {saver1.Balance:C2}");
			Console.WriteLine($"\n** CalculateInterest() Month 2:");
			Console.WriteLine($"Credit saver1 {saver1.CalculateInterest():C2} interest.");
			Console.WriteLine($"saver1.Balance: {saver1.Balance:C2}");
			Console.WriteLine($"\n** CalculateInterest() Month 3:");
			Console.WriteLine($"Credit saver1 {saver1.CalculateInterest():C2} interest.");
			Console.WriteLine($"saver1.Balance: {saver1.Balance:C2}");

			//Test CheckingAccount Credit(n) method
			Console.WriteLine("\n** Credit checking1 $50.00:");
			checking1.Credit(50.00m);
			Console.WriteLine($"checking1.Balance: {checking1.Balance:C2}");

			//Test CheckingAccount Debit(n) method
			Console.WriteLine("\n** Debit checking1 $50.00:");
			checking1.Debit(50.00m);
			Console.WriteLine($"checking1.Balance: {checking1.Balance:C2}");

			//Output final balances
			Console.WriteLine("\n** Final Balances:");
			Console.WriteLine($"account1.Balance: {account1.Balance:C2}");
			Console.WriteLine($"saver1.Balance: {saver1.Balance:C2}");
			Console.WriteLine($"checking1.Balance: {checking1.Balance:C2}");

			//Done
			Console.WriteLine($"\nProgram finished.");
		}
	}
}
