﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5570
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f12 = new Form1();
            f12.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user, pass;
            user=textBox1.Text;
            pass=textBox2.Text;

            Form1 f1 = new Form1(user,pass);
            this.Hide();
            Form1 f12 = new Form1();
            f12.Show();
            this.Hide();

        }
    }
}
