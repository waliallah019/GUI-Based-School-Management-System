﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form6();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new logIn();
            f.Show();
            this.Hide();
        }
    }
}
