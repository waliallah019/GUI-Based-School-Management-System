using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form15();
            setForm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form9();
            setForm(f);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form12();
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
