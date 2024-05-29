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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aName = name.Text;
            Char aGender = char.Parse(gender.Text);
            string aDOB = DOB.Text;
            string aContactNo = contactNo.Text;
            int aID = 0;
            double aSalary = 0;
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
            if (Validations.DoubleValidation(salary.Text))
            {
                aSalary = double.Parse(salary.Text);

            }
            else
            {
                salary.Text = "";
                MessageBox.Show("Error: Salary can only be in numbers\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Admin s in AdminDL.admins)
            {
                if (s.ID1 == aID)
                {
                    MessageBox.Show("Error: An Admin with same id already exists\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id.Text = "";
                    ClearDataFromForm();
                    return;
                }
            }
            string aUsername = username.Text;
            string aPassword = password.Text;
            foreach (User s in UserDL.users)
            {
                if (s.getUsername() == aUsername)
                {
                    MessageBox.Show("Error: Same username already exists in the system\nRenter Data", "Recurrsion Error",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                    username.Text = "";
                    password.Text = "";
                    ClearDataFromForm();
                    return;
                }
            }
            Admin user = new Admin(aName,aGender, aDOB, aContactNo,aID, "Admin", aUsername, aPassword, aSalary);
            AdminDL.addAdminIntoList(user);
            string path = "E:\\Assignments\\Project\\Data\\admin_data.txt";
            AdminDL.storeIntoFile(path, user);
            MessageBox.Show("Admin has been added");
            ClearDataFromForm();
        }
        private void ClearDataFromForm()
        {
            name.Text = "";
            gender.Text = "";
            DOB.Text = "";
            contactNo.Text = "";
            id.Text = "";
            salary.Text = "";
            username.Text = "";
            password.Text = "";
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
