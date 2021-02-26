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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0")) {
                textBox1.Text += zero.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void append(Button button) {

            if (!textBox1.Text.Equals("0"))
            {
                textBox1.Text += button.Text;
            }
            else {

                textBox1.Text = button.Text;
            }
          
        }

    }
        
}
