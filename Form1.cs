namespace Income_Tax_Calculator
{
    public partial class Form1 : Form
    {
        //two variables to calculate tax and round it off   s   
        decimal tax;
        decimal RoundedTax;
        public Form1()
        {
            InitializeComponent();
        }
        //Event handler triggers calculateTaxOnIncome() function when calculate button is clicked
        //first if statement validates the input using function inputValidation
        //second if statement checks if the number is a negative number
        ///last statement outputs the result on the text box
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!inputValidation())
            {
                
                return;

            }
            decimal income = Convert.ToDecimal(txtTaxableIncome.Text);
            if (income < 0)
            {
                MessageBox.Show("Input cannot be a negative number", "cant be a negative number");
                txtTaxableIncome.Clear();
                return;
            }
            calculateTaxOnIncome(income);
            
            txtTaxOwed.Text = RoundedTax.ToString("c");
        }
        //nested if-else if statements to identify tax brackets in this function
        public void calculateTaxOnIncome(decimal income)
        {
            if (income >= 0 && income <= 11000)
            {
                tax = income * 0.1m;
            }
            else if (income > 11000 && income <= 44725)
            {
                tax = 1100 + (0.12m * (income - 11000));
            }
            else if (income > 44725 && income <= 95375)
            {
                tax = 5147 + (0.22m * (income - 44725));
            }
            else if (income > 95375 && income <= 182100)
            {
                tax = 16290 + (0.24m * (income - 95375));
            }
            else if (income > 182100 && income <= 231250)
            {
                tax = 37104 + (0.32m * (income - 182100));
            }
            else if (income > 231250 && income <= 578125)
            {
                tax = 52832 + (0.35m * (income - 231250));
            }
            else if (income > 578125)
            {
                tax = 174238.25m + (0.37m * (income - 578125));
            }
            RoundedTax = Math.Round((decimal)tax, 2);
        }
        //this event handler triggers an exit from the program 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //validating if the input is valid using decimal.TryParse which returns a message box with an error message if input invalid
        public bool inputValidation()
        {
            if (!decimal.TryParse(txtTaxableIncome.Text, out decimal amt))
            {
                txtTaxOwed.Clear();
                MessageBox.Show("Please enter a valid input", "Invalid input");
                txtTaxableIncome.Clear();

                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
