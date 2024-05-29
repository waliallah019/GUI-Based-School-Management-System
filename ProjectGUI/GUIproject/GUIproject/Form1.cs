using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.BL;
using GUIproject.DL;
using System.Windows.Forms;

namespace GUIproject
{
    
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearDataFromRecord()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            User validUser = User.Authentication(username, password);
            if (validUser != null)
            {
                if (validUser.getRole() == "Admin")
                {
                    Form f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                    if (validUser.getRole() == "Teacher")
                {
                    Form f = new Form7();
                    f.Show();
                    this.Hide();
                }
                else
                    if (validUser.getRole() == "Student")
                {
                    Form f = new Form23();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("incorrect username or password.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDataFromRecord();
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the beep sound when Enter key is pressed
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
