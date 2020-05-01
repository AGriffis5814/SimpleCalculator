using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }
        /************************************
         * Andrea Griffis
         * 4/30/20
         * Teamwork Assignment Extra Excercise 6-1
         * Create Simple Calculator
         * ***********************************/
        
        // private method that does the calculations with given user input
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            switch (operator1)
            {
                case "+":
                    txtResult.Text = (operand1 + operand2).ToString("f4");
                    break;
                case "-":
                    txtResult.Text = (operand1 - operand2).ToString("f4");
                    break;
                case "*":
                    txtResult.Text = (operand1 * operand2).ToString("f4");
                    break;
                case "/":
                    txtResult.Text = (operand1 / operand2).ToString("f4");
                    break;
                default:
                    MessageBox.Show("Only use +, -, *, or /");
                    break;
            }
          
            return Convert.ToDecimal(txtResult.Text);

        }
        // calculate button click method
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
           
            // Calls the Calculate method
            decimal txtresult = Calculate(operand1, operator1, operand2);

            txtResult.Text = txtresult.ToString("n4");
            // brings focus back to the first operand text box
            txtOperand1.Focus();

        }

        
        // Method that clears the text in the results text box
        private void ClearResults(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        // Method that closes the form when th exit/esc is used
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
