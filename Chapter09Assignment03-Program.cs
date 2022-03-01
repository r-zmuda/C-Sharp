using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Querying an Array of Invoice Objects
namespace Chapter09Assignment03
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declare Invoice array
			Invoice [] invoice = new Invoice[8];

			//Create Invoice objects
			invoice[0] = new Invoice(83, "Electric sander", 7, 7.98m);
			invoice[1] = new Invoice(24, "Power saw", 18, 99.99m);
			invoice[2] = new Invoice(7, "Sledge hammer", 11, 21.50m);
			invoice[3] = new Invoice(77, "Hammer", 76, 11.99m);
			invoice[4] = new Invoice(39, "Lawn mower", 3, 79.50m);
			invoice[5] = new Invoice(68, "Screwdriver", 106, 9.99m);
			invoice[6] = new Invoice(56, "Jig saw", 21, 11.00m);
			invoice[7] = new Invoice(3, "Wrench", 34, 7.50m);

			//Display initial values
			Console.WriteLine("Initial values:");
			//Header
			Console.WriteLine(string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
				"Part#", "Part Description", "Qty", "Price"));
			//Output
			foreach (var i in invoice)
			{
				Console.WriteLine(i.ToString());
			}
			Console.WriteLine();

			//a) Use LINQ to sort the Invoice objects by PartDescription.
			Console.WriteLine("Sorted by Part Description:");
			//Header
			Console.WriteLine(string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
				"Part#", "Part Description", "Qty", "Price"));
			var descriptionSort =
				from i in invoice
				orderby i.PartDescription
				select i;
			//Output
			foreach (var n in descriptionSort)
			{
				Console.WriteLine(n.ToString());
			}
			Console.WriteLine();

			//b) Use LINQ to sort the Invoice objects by Price.
			Console.WriteLine("Sorted by Price:");
			//Header
			Console.WriteLine(string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
				"Part#", "Part Description", "Qty", "Price"));
			var priceSort =
				from i in invoice
				orderby i.Price
				select i;
			//Output
			foreach (var n in priceSort)
			{
				Console.WriteLine(n.ToString());
			}
			Console.WriteLine();

			//c) Use LINQ to select the PartDescription and Quantity and
			//sort the results by Quantity.
			Console.WriteLine("Sorted by Quantity:");
			var qtySort =
				from i in invoice
				orderby i.Quantity
				select new { Part = i.PartDescription, Qty = i.Quantity };
			//Output
			foreach (var n in qtySort)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine();

			//d) Use LINQ to select from each Invoice the PartDescription and
			//the value of the Invoice (i.e. Quantity * Price). Name the calculated
			//column InvoiceTotal. Order the results by Invoice value. [Hint: Use
			//let to store the result of Quantity * Price in a new range variable total.]
			Console.WriteLine("Sorted by Total:");
			var totalSort =
				from i in invoice
				let invoiceTotal = i.Quantity * i.Price
				orderby invoiceTotal
				select new { Part = i.PartDescription, Total = "$" + invoiceTotal };
			//Output
			foreach (var n in totalSort)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine();

			//e) Using the results of the LINQ query in part (d), select the InvoiceTotals
			//in the range $200 to $500.
			Console.WriteLine("Sorted by Total (Range $200-$500):");
			var rangeSort =
				from i in invoice
				let invoiceTotal = i.Quantity * i.Price
				where invoiceTotal > 200 && invoiceTotal < 500
				orderby invoiceTotal
				select new { Part = i.PartDescription, Total = "$" + invoiceTotal };
			//Output
			foreach (var n in rangeSort)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine();
		}
	}
}
