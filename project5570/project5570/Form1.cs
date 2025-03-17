using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project5570
{
    public partial class Form1 : Form
    {
        public string user, pass;
        public Form1(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
           MessageBox.Show("pass"+pass + " user " +user);
            

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5=new Form5();
            this.Hide();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                if (textBox1.Text == "Admin" && textBox2.Text == "123"|| textBox1.Text == user && textBox2.Text == pass)
                {
                    MessageBox.Show("You are successfully Login");
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                 
                else
                {
                    MessageBox.Show("User name or password incorrect");
                }
            }
        }

       
    }
}

