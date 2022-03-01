using System;

public class Employee
{
	public string FName { get; set; }
	public string LName { get; set; }
	public decimal Salary { get; set; }

	public Employee() {
	}

	public Employee(string firstName, string lastName, decimal monthSalary) {
		FName = firstName;
		LName = lastName;
		Salary = monthSalary;
	}
}
