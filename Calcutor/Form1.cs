namespace Calcutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Caltotal;
        double num1;
        double num2;
        string option;
        double result;

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            if (option.Equals("-"))
            {
                result = num1 - num2;
            }
            if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            if (option.Equals("/"))
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    textBox1.Text = "Error";
                    return;
                }
            }

            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Sin(value * Math.PI / 180);
                textBox1.Text = result.ToString("0.####");
            }
            else
            {
                textBox1.Text = "Error";
            }
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
            }
            else if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Cos(value * Math.PI / 180);
                textBox1.Text = result.ToString("0.####");
            }
            else
            {
                textBox1.Text = "Error";
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                if (value % 180 == 90)
                {
                    textBox1.Text = "Error";
                }
                else
                {
                    double result = Math.Tan(value * Math.PI / 180);
                    textBox1.Text = result.ToString("0.####");
                }
            }
            else
            {
                textBox1.Text = "Error";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Sin(value * Math.PI / 180); // Convert degrees to radians
                textBox1.Text = result.ToString("0.####");
            }
            else
            {
                textBox1.Text = "Error";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Cos(value * Math.PI / 180); // Convert degrees to radians
                textBox1.Text = result.ToString("0.####");
            }
            else
            {
                textBox1.Text = "Error";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                if (value % 180 == 90) // Check for undefined tangent
                {
                    textBox1.Text = "Error";
                }
                else
                {
                    double result = Math.Tan(value * Math.PI / 180); // Convert degrees to radians
                    textBox1.Text = result.ToString("0.####");
                }
            }
            else
            {
                textBox1.Text = "Error";
            }

        }
    }
}

