using System;

public class SavingsAccount
{
	//Annual Interest Rate
	public static decimal rate;
	public decimal savings;

	//Properties
	public static decimal AnnualInterestRate
	{
		get
		{
			return rate;
		}
		set
		{
			rate = value / 100;
		}
	}

	public decimal SavingsBalance
	{
		get
		{
			return savings;
		}
		set
		{
			savings = value;
		}
	}

	//Constructor
	public SavingsAccount(decimal n)
	{
		savings = n;
	}

	//Methods
	public decimal CalculateMonthlyInterest()
	{
		//Calculation
		savings = savings + (SavingsBalance * AnnualInterestRate / 12);
		return savings;
	}
}
