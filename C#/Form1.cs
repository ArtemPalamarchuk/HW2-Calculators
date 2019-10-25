using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string operation;
        public string saveVal;
        public bool second;
        public Form1()
        {
            InitializeComponent();
        }
        // Numbers
        private void Form1_Click(object sender, EventArgs e)
        {
            if (second)
            {
                second = false;
                textBox1.Text = "";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text += B.Text;
            }
        }
        //Reset - C button
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        // Operations
        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            operation = B.Text;
            saveVal = textBox1.Text;
            second = true;
        }
        // Equal
        private void button15_Click(object sender, EventArgs e)
        {
            double x, y, result;
            result = 0;
            x = Convert.ToDouble(saveVal);
            y = Convert.ToDouble(textBox1.Text);
            if (operation == "+")
            {
                result = x + y;
            }
            if (operation == "-")
            {
                result = x - y;
            }
            if (operation == "*")
            {
                result = x * y;
            }
            if (operation == "/")
            {
                result = x / y;
            }
            operation = "=";
            second = true;
            textBox1.Text = result.ToString();
        }
    }
}
