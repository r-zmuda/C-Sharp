using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Assignment09
{
	class SavingsAccount : Account
	{
		private static decimal rate;
		private decimal interest;

		//Properties
		public decimal AnnualInterestRate
		{
			get
			{
				return rate;
			}
			set
			{
				rate = value;
			}
		}

		//Constructors
		public SavingsAccount(decimal n, decimal r) : base(n)
		{
			rate = r;
		}
		public SavingsAccount(decimal n) : base(n)
		{
		}

		//Methods
		public decimal CalculateInterest()
		{
			//Calculation
			interest = Balance * (AnnualInterestRate / 100) / 12;
			Credit(interest);
			return interest;
		}
	}
}
