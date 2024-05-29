using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using GUIproject.BL;
using GUIproject.DL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIproject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void setForm(Form form)
        {
            panel3.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            panel3.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form8();
            setForm(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form11();
            setForm(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form14();
            setForm(f);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
