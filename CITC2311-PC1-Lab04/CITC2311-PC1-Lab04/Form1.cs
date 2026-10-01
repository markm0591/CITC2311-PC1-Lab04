namespace CITC2311_PC1_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result;
            switch (operator1)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
                default:
                    throw new ArgumentException("Operator must be +, -, *, or /.");
            }
            return result;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(Operand1TxtBx.Text);
                string operator1 = OperatorTxtBx.Text;
                decimal operand2 = Convert.ToDecimal(Operand2TxtBx.Text);

                decimal result = Calculate(operand1, operator1, operand2);
                ResultTxtBx.Text = result.ToString("n4");
                Operand1TxtBx.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for both operands.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value entered is too large. Please enter a smaller number.", "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide-by-zero error. You cannot divide by zero.", "Entry Error");
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine + Environment.NewLine
                    + ex.GetType().ToString() + Environment.NewLine + Environment.NewLine
                    + ex.StackTrace;
                MessageBox.Show(message, "Error");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Operand_TextChanged(object sender, EventArgs e)
        {
            ResultTxtBx.Clear();
        }
    }
}