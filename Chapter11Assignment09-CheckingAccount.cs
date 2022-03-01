using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Assignment09
{
	class CheckingAccount : Account
	{
		private static decimal fee;

		//Properties
		public decimal Fee
		{
			get
			{
				return fee;
			}
			set
			{
				fee = value;
			}
		}

		//Constructors
		public CheckingAccount(decimal n, decimal f) : base(n)
		{
			fee = f;
		}
		public CheckingAccount(decimal n) : base(n)
		{
		}

		//Methods
		public override void Credit(decimal n)
		{
			Balance += n - fee;
		}
		public override void Debit(decimal n)
		{
			//Check if enoguh balance
			if (n > Balance)
			{
				Console.WriteLine("Debit amount exceeded account balance.");
			}
			else
			{
				Balance -= n + fee;
			}
		}
	}
}
