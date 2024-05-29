using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIproject.BL;
using GUIproject.DL;

namespace GUIproject
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aID = 0;
            if (Validations.IntValidation(id.Text))
            {
                aID = int.Parse(id.Text);

            }
            else
            {
                id.Text = "";
                MessageBox.Show("Error: Id can only be integer\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            foreach (Admin s in AdminDL.admins)
            {
                if (s.ID1 == aID && s.getUsername() == username.Text && s.getPassword() == password.Text)
                {
                    AdminDL.removeAdmin(s);
                    string path = "E:\\Assignments\\Project\\Data\\teacher_data.txt";
                    AdminDL.updateFileData(path);
                    MessageBox.Show("Admin of badge no " + s.ID1+ " whose name is " + s.Name + " has been removed ");
                    ClearDataFromForm();
                    return;
                }
            }
            MessageBox.Show("Invalid Credentials");
            ClearDataFromForm();
        }
        private void ClearDataFromForm()
        {
            id.Text = "";
            username.Text = "";
            password.Text = "";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
