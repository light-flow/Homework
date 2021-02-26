using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkOne
{
    public partial class calu : Form
    {
        public calu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numberOne=0;
            double numberTwo=0;
            try {
                numberOne = double.Parse(number_one.Text);
                numberTwo = double.Parse(number_two.Text);
            } catch (Exception exception) {
                result.Text = "数据输入错误";
                return;
            }
            
            double re = 0;
            String oper = op.Text;
            switch (oper) {
                case "*": re = numberOne * numberTwo;break;
                case "+": re = numberOne + numberTwo;break;
                case "/": {
                        if (numberTwo == 0) {
                            result.Text = "除数不可以为0";
                            return;
                        }
                        re = numberOne / numberTwo; break; } 
                case "-": re = numberOne - numberTwo;break;
            }
            result.Text = re.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appendNumber(seven);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            number_one.Text = "0";
            number_two.Text = "0";
            result.Text = "0";
            op.Text = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            appendNumber(zero);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void appendNumber(Button button) {
            if (!op.Text.Equals(""))
            {
                if (number_two.Text.Equals("0"))
                {
                    number_two.Text = button.Text;
                }
                else
                {
                    number_two.Text += button.Text;
                }
            }
            else {
                if (number_one.Text.Equals("0") && !button.Text.Equals("."))
                {
                    number_one.Text = button.Text;

                }
                else {
                    number_one.Text += button.Text;
                }
            
            }
           
          
        }
        private void appendOperator(Button button) {
            op.Text = button.Text;
        }

        private void number_two_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            appendNumber(one);
        }

        private void two_Click(object sender, EventArgs e)
        {
            appendNumber(two);
        }

        private void three_Click(object sender, EventArgs e)
        {
            appendNumber(three);
        }

        private void multplicate_Click(object sender, EventArgs e)
        {
            appendOperator(multplicate);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            appendOperator(divide);
        }

        private void four_Click(object sender, EventArgs e)
        {
            appendNumber(four);
        }

        private void five_Click(object sender, EventArgs e)
        {
            appendNumber(five);
        }

        private void six_Click(object sender, EventArgs e)
        {
            appendNumber(six);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            appendOperator(minus);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            appendNumber(eight);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            appendNumber(nine);
        }

        private void add_Click(object sender, EventArgs e)
        {
            appendOperator(add);
        }

        private void point_Click(object sender, EventArgs e)
        {
            appendNumber(point);
        }
    }
        
}
