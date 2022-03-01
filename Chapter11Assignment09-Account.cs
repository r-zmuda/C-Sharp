using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Assignment09
{
	class Account
	{
		private decimal balance;

		//Properties
		public decimal Balance
		{
			get
			{
				return balance;
			}
			set
			{
				//Validation
				if (value < 0.00m)
				{
					throw new ArgumentOutOfRangeException(nameof(value), value,
						$"{nameof(Balance)} must be greater than 0.");
				}
				else
				{
					balance = value;
				}
			}
		}

		//Constructors
		public Account(decimal n)
		{
			balance = n;
		}

		//Methods
		public virtual void Credit(decimal n)
		{
			balance += n;
		}
		public virtual void Debit(decimal n)
		{
			//Check if enough balance
			if (n > balance)
			{
				Console.WriteLine("Debit amount exceeded account balance.");
			}
			else
			{
				balance -= n;
			}
		}
	}
}
