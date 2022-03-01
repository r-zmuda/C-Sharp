using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Temperature Conversions
namespace Chapter14Assignment06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			FahrenheitTextbox.Text = "0";
			CelsiusLabel.Text = "0";
		}

		//Perform temperature conversion
		private void ConvertButton_Click(object sender, EventArgs e)
		{
			//Output result, catch invalid input
			if (Decimal.TryParse(FahrenheitTextbox.Text, out decimal fahrenheit))
			{
				decimal celsius = (fahrenheit - 32.0m) * (5.0m / 9.0m);
				CelsiusLabel.Text = $"{celsius:F3}";
			}
			else
			{
				CelsiusLabel.Text = $"ERROR";
			}
		}
	}
}
