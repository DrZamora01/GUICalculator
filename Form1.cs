using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class Form1 : Form
    {
        private decimal FirstNum = 0.0m;
        private decimal SecondNum = 0.0m;
        private decimal Results = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }
        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
            { 
                textBox1.Text += ".";
            }
        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            FirstNum = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "-";
        }
        private void plusBtn_Click(object sender, EventArgs e)
        {
            FirstNum = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "+";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            FirstNum = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "/";
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            FirstNum = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "*";
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            FirstNum = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "%";
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    SecondNum= decimal.Parse(textBox1.Text);
                    Results =  FirstNum - SecondNum;
                    textBox1.Text = Results.ToString();
                    break;

                case "+":
                    SecondNum = decimal.Parse(textBox1.Text);
                    Results = FirstNum + SecondNum;
                    textBox1.Text = Results.ToString();
                    break;
                case "/":
                    SecondNum = decimal.Parse(textBox1.Text);
                    Results = FirstNum / SecondNum;
                    textBox1.Text = Results.ToString();
                    break;
                case "*":
                    SecondNum = decimal.Parse(textBox1.Text);
                    Results = FirstNum * SecondNum;
                    textBox1.Text = Results.ToString();
                    break;
                case "%":
                    SecondNum = decimal.Parse(textBox1.Text);
                    Results = FirstNum % SecondNum;
                    textBox1.Text = Results.ToString();
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            FirstNum = 0.0m;
            SecondNum = 0.0m;
            textBox1.Text = "0";
        }
    }
}
