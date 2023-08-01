using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Calculator : Form
    {
        // Declare private variables to store values and operator for calculations
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+"; // Initialize the default operator as addition

        public Calculator()
        {
            InitializeComponent();
        }

        // Event handlers for digit buttons (0 to 9)
        // Append the clicked digit to the display text box, handles leading zeros
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0") 
               TxtBox.Text = "0";   
            else
                TxtBox.Text += "0";
        }

        // Event handlers for the decimal (dot) button
        // Appends a decimal point to the text box if there is no existing decimal
        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains(".")) 
                TxtBox.Text += ".";
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "1";
            else
                TxtBox.Text += "1";
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "2";
            else
                TxtBox.Text += "2";
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "3";
            else
                TxtBox.Text += "3";
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "4";
            else
                TxtBox.Text += "4";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "5";
            else
                TxtBox.Text += "5";
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "6";
            else
                TxtBox.Text += "6";
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "7";
            else
                TxtBox.Text += "7";
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
                TxtBox.Text = "8";          
            else
                TxtBox.Text += "8";
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0") 
                TxtBox.Text = "9";
            else
                TxtBox.Text += "9";
        }

        // Event handlers for operator buttons (minus, plus, divide, multiply, percent)
        // Store the current value in the text box as valuefirst
        // Clear the text box for entering the next value
        // Update the operator based on the clicked button
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";       
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
            
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        // Event handler for the equal button
        // Perform the arithmetic operation based on the stored operator and display the result
        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators) 
            {
                case "-":
                    valuesecond = decimal.Parse(TxtBox.Text);
                    result = valuefirst - valuesecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "+":
                    valuesecond = decimal.Parse(TxtBox.Text);
                    result = valuefirst + valuesecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "*":
                    valuesecond = decimal.Parse(TxtBox.Text);
                    result = valuefirst * valuesecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "/":
                    valuesecond = decimal.Parse(TxtBox.Text);
                    result = valuefirst / valuesecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "%":
                    valuesecond = decimal.Parse(TxtBox.Text);
                    result = valuefirst % valuesecond;
                    TxtBox.Text = result.ToString();
                    break;       
            }
        }

        // Event handler for the clear button
        // Reset all values to zero and clear the text box
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valuefirst = 0.0m;
            valuesecond = 0.0m;
            TxtBox.Text = "0";
        }
    }   
}
