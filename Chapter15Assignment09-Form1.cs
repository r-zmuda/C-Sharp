using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter15Assignment09
{
	public partial class Form1 : Form
	{
		//Set tax rate
		decimal taxRate = 6.5m;

		//Initialize
		decimal subtotal = 0.0m;
		decimal tax = 0.0m;
		decimal total = 0.0m;
		public Form1()
		{
			InitializeComponent();
			SubtotalLabel.Text = "";
			TaxLabel.Text = "";
			TotalLabel.Text = "";
			OrderList.Text = "";
		}

		//Select beverage
		private void BeverageBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (BeverageBox.SelectedIndex)
			{
				case 0: subtotal = subtotal + 1.95m; break;
				case 1: subtotal = subtotal + 1.50m; break;
				case 2: subtotal = subtotal + 1.25m; break;
				case 3: subtotal = subtotal + 2.95m; break;
				case 4: subtotal = subtotal + 2.50m; break;
				case 5: subtotal = subtotal + 1.50m; break;
			}
			OrderList.Items.Add(BeverageBox.SelectedItem);
			newTotal();
		}

		//Select appetizer
		private void AppetizerBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (AppetizerBox.SelectedIndex)
			{
				case 0: subtotal = subtotal + 5.95m; break;
				case 1: subtotal = subtotal + 6.95m; break;
				case 2: subtotal = subtotal + 8.95m; break;
				case 3: subtotal = subtotal + 8.95m; break;
				case 4: subtotal = subtotal + 10.95m; break;
				case 5: subtotal = subtotal + 12.95m; break;
				case 6: subtotal = subtotal + 6.95m; break;
			}
			OrderList.Items.Add(AppetizerBox.SelectedItem);
			newTotal();
		}

		//Select main course
		private void MainCourseBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (MainCourseBox.SelectedIndex)
			{
				case 0: subtotal = subtotal + 15.95m; break;
				case 1: subtotal = subtotal + 13.95m; break;
				case 2: subtotal = subtotal + 13.95m; break;
				case 3: subtotal = subtotal + 11.95m; break;
				case 4: subtotal = subtotal + 19.95m; break;
				case 5: subtotal = subtotal + 20.95m; break;
				case 6: subtotal = subtotal + 18.95m; break;
				case 7: subtotal = subtotal + 13.95m; break;
				case 8: subtotal = subtotal + 14.95m; break;
			}
			OrderList.Items.Add(MainCourseBox.SelectedItem);
			newTotal();
		}

		//Select dessert
		private void DessertBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (DessertBox.SelectedIndex)
			{
				case 0: subtotal = subtotal + 5.95m; break;
				case 1: subtotal = subtotal + 3.95m; break;
				case 2: subtotal = subtotal + 5.95m; break;
				case 3: subtotal = subtotal + 4.95m; break;
				case 4: subtotal = subtotal + 5.95m; break;
			}
			OrderList.Items.Add(DessertBox.SelectedItem);
			newTotal();
		}

		//Click to reset the form
		private void ClearBillButton_Click(object sender, EventArgs e)
		{
			BeverageBox.Text = "";
			AppetizerBox.Text = "";
			MainCourseBox.Text = "";
			DessertBox.Text = "";
			SubtotalLabel.Text = "";
			TaxLabel.Text = "";
			TotalLabel.Text = "";
			subtotal = 0.0m;
			tax = 0.0m;
			total = 0.0m;
			//Clear list
			for (int x = OrderList.Items.Count; x > 0; x--)
			{
				OrderList.Items.RemoveAt(0);
			}
		}

		//Click to exit the form
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		//Calculate and output totals
		private void newTotal()
		{
			tax = (subtotal * (taxRate / 100));
			total = subtotal + tax;

			SubtotalLabel.Text = String.Format("{0:C2}", subtotal);
			TaxLabel.Text = String.Format("{0:C2}", tax);
			TotalLabel.Text = String.Format("{0:C2}", total);
		}

		private void SubtotalLabel_Click(object sender, EventArgs e)
		{

		}

		private void TaxLabel_Click(object sender, EventArgs e)
		{

		}

		private void TotalLabel_Click(object sender, EventArgs e)
		{

		}

		private void OrderList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
