using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRegister(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Incomplete");
            }
            else
            {
                s.registerUser(textBox1.Text, textBox2.Text);
                MessageBox.Show("User has been Regisrered Successfully");
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblLoginForm(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }
    }
}
