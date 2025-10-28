namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // this event handler is triggered when the calculate button is clicked
        // chekcs if the validator passed the validation for operands and operator
        //converts and assigns the inputs from the user 
        //checks if the operator is division and operand 2 is 0 and returns error
        //Rounds off the result to 4 decimal places 
        //assigns the result to the textbox
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!validator() || !operatorValidator())
            {
                return;
            }
            decimal op1 = Convert.ToDecimal(txtOperand1.Text);
            decimal op2 = Convert.ToDecimal(txtOperand2.Text);
            string opr = Convert.ToString(txtOperator.Text);
            if (opr == "/" && op2 == 0) 
            {
                MessageBox.Show("cant divide by zero", "zero error");
                txtOperand2.Clear();
                return;
            }
            txtResult.Text = Convert.ToString(Math.Round(Calculate(op1, op2, opr), 4).ToString("F4"));
            txtOperand1.Focus();

        }
        //calculates based on the operator choice by the user
        //takes three arguments
        private static  decimal Calculate(decimal op1, decimal op2, string opr)
        {
            decimal result = 0;
            if (opr == "+")
            {
                result = op1 + op2;
            }
            else if (opr == "-")
            {
                result = op1 - op2;
            }
            else if (opr == "*")
            {
                result = op1 * op2;
            }
            else if (opr == "/" && op2!=0)
            {
                result = op1 / op2;
            }
            return result;
        }
        //validates the operand 1 and operand 2 inout by the user
        //uses decimal.TryParse for validation
        //clears the boxes if invalid input
        //error message box shown if invalid 
        private bool validator()
        {
            if ((!decimal.TryParse(txtOperand1.Text, out decimal amt)) || (!decimal.TryParse(txtOperand2.Text, out decimal amt2)))
            {
                MessageBox.Show("Invalid Operands. Please input correct operand(s)", "invalid operands");
                txtOperand1.Clear();
                txtOperand2.Clear();
                return false;
            }
            return true;
        }
        //Validates the operator input by the user
        //error message box shown if invalid operator
        private bool operatorValidator()
        {
            string opr = txtOperator.Text;
            if (opr == "+" || opr == "-" || opr == "*" || opr == "/")
            {
                return true;
            }
            else
            {
                MessageBox.Show("please input a valid operator", "invalid operator");
                txtOperator.Clear();
                return false;
            }

        }
        //exits the application

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}