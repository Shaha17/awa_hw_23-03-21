using System;
using System.Windows.Forms;

namespace DZ_23_03_21
{
	public partial class Main : Form
	{
		private double x = 0;
		private double y = 0;
		private double rez = 0;
		private double z = 0;
		private double inputedNumber = 0;
		private string mathOper;
		public Main()
		{
			InitializeComponent();
		}

		private void clearAllBtn_Click(object sender, EventArgs e)
		{
			x = 0;
			y = 0;
			rez = 0;
			z = 0;
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
		}

		private void backspaceBtn_Click(object sender, EventArgs e)
		{
			string content = resultsTextBox.Text;
			if(content.Length < 1)
			{
				return;
			}
			resultsTextBox.Text = content.Remove(content.Length - 1);
		}

		private void divBtn_Click(object sender, EventArgs e)
		{
			x = inputedNumber;
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
			mathOper = "/";
		}

		private void multiBtn_Click(object sender, EventArgs e)
		{
			x = inputedNumber;
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
			mathOper = "*";
		}

		private void minusBtn_Click(object sender, EventArgs e)
		{
			x = inputedNumber;
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
			mathOper = "-";
		}

		private void plusBtn_Click(object sender, EventArgs e)
		{
			x = inputedNumber;
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
			mathOper = "+";
		}

		private void oneDivXBtn_Click(object sender, EventArgs e)
		{
			try
			{
				x = 1;
				y = inputedNumber;
				if(y == 0)
				{
					throw new DivideByZeroException();
				}
				rez = x / y;
				inputedNumber = rez;
				resultsTextBox.Text = rez.ToString().Replace(',', '.');
			}
			catch(DivideByZeroException ex)
			{
				textBoxTip.ToolTipIcon = ToolTipIcon.Error;
				textBoxTip.Show(ex.Message, resultsTextBox, 1000);
				return;
			}
		}

		private void modBtn_Click(object sender, EventArgs e)
		{
			x = inputedNumber;
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
			mathOper = "%";
		}

		private void sqrtBtn_Click(object sender, EventArgs e)
		{
			z = inputedNumber;
			rez = Math.Sqrt(z);
			inputedNumber = rez;
			resultsTextBox.Text = rez.ToString().Replace(',', '.');
		}

		private void mPlusBtn_Click(object sender, EventArgs e)
		{
			Memory.Plus(inputedNumber);
		}

		private void msBtn_Click(object sender, EventArgs e)
		{
			Memory.Store(inputedNumber);
		}

		private void mrBtn_Click(object sender, EventArgs e)
		{
			inputedNumber = Memory.Recall();
			resultsTextBox.Text = inputedNumber.ToString().Replace(',', '.');
		}

		private void mcBtn_Click(object sender, EventArgs e)
		{
			Memory.Clear();
		}

		private void clearCurrentBtn_Click(object sender, EventArgs e)
		{
			inputedNumber = 0;
			resultsTextBox.Text = string.Empty;
		}

		private void posNegBtn_Click(object sender, EventArgs e)
		{
			inputedNumber *= (-1);
			resultsTextBox.Text = inputedNumber.ToString();
		}

		private void zeroBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
				return;

			resultsTextBox.Text += "0";
		}

		private void oneBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "1";
				return;
			}
			resultsTextBox.Text += "1";
		}

		private void twoBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "2";
				return;
			}
			resultsTextBox.Text += "2";
		}

		private void threeBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "3";
				return;
			}
			resultsTextBox.Text += "3";
		}

		private void fourBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "4";
				return;
			}
			resultsTextBox.Text += "4";
		}

		private void fiveBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "5";
				return;
			}
			resultsTextBox.Text += "5";
		}

		private void sixBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "6";
				return;
			}
			resultsTextBox.Text += "6";
		}

		private void sevenBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "7";
				return;
			}
			resultsTextBox.Text += "7";
		}

		private void eightBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "8";
				return;
			}
			resultsTextBox.Text += "8";
		}

		private void nineBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Equals("0"))
			{
				resultsTextBox.Text = "9";
				return;
			}
			resultsTextBox.Text += "9";
		}

		private void resultsTextBox_TextChanged(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Length > 0)
			{
				inputedNumber = double.Parse(resultsTextBox.Text.ToString().Replace('.', ','));
			}
		}

		private void doubleBtn_Click(object sender, EventArgs e)
		{
			if(resultsTextBox.Text.Contains(".") || resultsTextBox.Text.Length == 0)
			{
				return;
			}

			resultsTextBox.Text += ".";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(inputedNumber.ToString());
		}

		private void equalBtn_Click(object sender, EventArgs e)
		{
			switch(mathOper)
			{
				case "+":
					{

						y = inputedNumber;
						rez = x + y;
						inputedNumber = rez;
						resultsTextBox.Text = rez.ToString().Replace(',', '.');
						break;
					}
				case "-":
					{

						y = inputedNumber;
						rez = x - y;
						inputedNumber = rez;
						resultsTextBox.Text = rez.ToString().Replace(',', '.');
						break;
					}
				case "*":
					{

						y = inputedNumber;
						rez = x * y;
						inputedNumber = rez;
						resultsTextBox.Text = rez.ToString().Replace(',', '.');
						break;
					}
				case "%":
					{

						y = inputedNumber;
						rez = ((x * y) / 100);
						inputedNumber = rez;
						resultsTextBox.Text = rez.ToString().Replace(',', '.');
						break;
					}
				case "/":
					{

						try
						{
							y = inputedNumber;
							if(y == 0)
							{
								throw new DivideByZeroException();
							}
							rez = x / y;
							inputedNumber = rez;
							resultsTextBox.Text = rez.ToString().Replace(',', '.');
						}
						catch(DivideByZeroException ex)
						{
							textBoxTip.ToolTipIcon = ToolTipIcon.Error;
							textBoxTip.Show(ex.Message, resultsTextBox, 1000);
							return;
						}
						break;
					}
			}
		}
	}
}
