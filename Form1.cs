namespace WinFormsApp1_calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = " ";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Reuslt.Text == "0") || (isOperationPerformed))
                textBox_Reuslt.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Reuslt.Text.Contains("."))
                    textBox_Reuslt.Text = textBox_Reuslt.Text + button.Text;
            }
            else
            textBox_Reuslt.Text = textBox_Reuslt.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button21.PerformClick();
                operationPerformed = button.Text;
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(textBox_Reuslt.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Reuslt.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_Reuslt.Text = "0";
            resultValue = 0;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Reuslt.Text = (resultValue + double.Parse(textBox_Reuslt.Text)).ToString();
                    break;

                case "-":
                    textBox_Reuslt.Text = (resultValue - double.Parse(textBox_Reuslt.Text)).ToString();
                    break;

                case "*":
                    textBox_Reuslt.Text = (resultValue * double.Parse(textBox_Reuslt.Text)).ToString();
                    break;

                case "/":
                    textBox_Reuslt.Text = (resultValue / double.Parse(textBox_Reuslt.Text)).ToString();
                    break;

                default:
                    break;

            }
            resultValue = double.Parse(textBox_Reuslt.Text);
            label1.Text = " ";
        }
    }
}