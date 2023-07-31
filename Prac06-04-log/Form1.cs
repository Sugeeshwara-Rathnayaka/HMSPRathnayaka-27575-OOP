using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loging_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Admin";
            string password = "Admin123";

            if (textBox1.Text == username)
            {
                if (textBox2.Text == password)
                {
                    Home objhome = new Home();
                    objhome.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password");
                label3.Text = "Try Again";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
}
