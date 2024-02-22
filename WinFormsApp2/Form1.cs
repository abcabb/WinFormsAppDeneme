namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            double num1, num2, sum = 0;
            num1 = double.Parse(numberOne.Text);
            num2 = double.Parse(numberTwo.Text);
            sum = num1 + num2;
            result.Text = sum.ToString();
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            double num1, num2, substract = 0;
            num1 = double.Parse(numberOne.Text);
            num2 = double.Parse(numberTwo.Text);
            substract = num1 - num2;
            result.Text = substract.ToString();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            double num1, num2, multiply = 1;
            num1 = double.Parse(numberOne.Text);
            num2 = double.Parse(numberTwo.Text);
            multiply = num1 * num2;
            result.Text=multiply.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double num1, num2, division = 1;
            num1= double.Parse(numberOne.Text);
            num2= double.Parse(numberTwo.Text);
            division = num1 / num2;
            result.Text = division.ToString();  
        }
    }
}
