using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;
            MessageBox.Show("Addistion result is " + result.ToString());
            label3.Text = "Sum Result is " + result.ToString();
            label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 - num2;
            MessageBox.Show("Substraction result is " + result.ToString());
            label3.Text = "Sub Result is " + result.ToString();
            label3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 * num2;
            MessageBox.Show("Multipication result is " + result.ToString());
            label3.Text = "Mul Result is " + result.ToString();
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 / num2;
            MessageBox.Show("Division result is " + result.ToString());
            label3.Text = "Div Result is " + result.ToString();
            label3.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 % num2;
            MessageBox.Show("Module result is " + result.ToString());
            label3.Text = "Mod Result is " + result.ToString();
            label3.Visible = true;
        }
    }
}
