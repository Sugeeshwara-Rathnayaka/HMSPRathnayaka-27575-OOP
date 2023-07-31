using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac06_02_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);
            int sum = Num1 + Num2;

            label1.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int sum = Num1 - Num2;

            label1.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int sum = Num1 * Num2;

            label1.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int sum = Num1 / Num2;

            label1.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
