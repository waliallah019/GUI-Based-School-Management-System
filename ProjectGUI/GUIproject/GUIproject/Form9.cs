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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tName = name.Text;
            Char tGender = char.Parse(gender.Text);
            string tDOB = DOB.Text;
            string tContactNo = contactNo.Text;
            int tID = 0;
            double tSalary = 0;
            int tGrade = 0;
            if (Validations.IntValidation(id.Text))
            {
                tID = int.Parse(id.Text);

            }
            else
            {
                id.Text = "";
                MessageBox.Show("Error: Id can only be integer\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validations.DoubleValidation(salary.Text))
            {
                tSalary = double.Parse(salary.Text);

            }
            else
            {
                salary.Text = "";
                MessageBox.Show("Error: Salary can only be in numbers\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validations.IntValidation(grade.Text, 1, 10))
            {
                tGrade = int.Parse(grade.Text);
            }
            else
            {
                grade.Text = "";
                MessageBox.Show("Error: Grade can only be integer and between 1 and 10\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Teacher s in TeacherDL.teachers)
            {
                if (s.ID1 == tID && s.Grade == tGrade)
                {
                    MessageBox.Show("Error: A Teacher with same id and grade already exists\n Renter Data", "Recurrsion Error",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                    grade.Text = "";
                    id.Text = "";
                    ClearDataFromForm();
                    return;
                }
            }
            string tUsername = username.Text;
            string tPassword = password.Text;
            foreach (User s in UserDL.users)
            {
                if (s.getUsername() == tUsername)
                {
                    MessageBox.Show("Error: Same username already exists in the system\nRenter Data", "Recurrsion Error",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                    username.Text = "";
                    password.Text = "";
                    ClearDataFromForm();
                    return;
                }
            }
            Teacher user = new Teacher(tName,tGender, tDOB, tContactNo,tID, "Teacher", tUsername, tPassword, tGrade, tSalary);
            TeacherDL.addTeacherIntoList(user);
            UserDL.users.Add(user);
            string path = "E:\\Assignments\\Project\\Data\\teacher_data.txt";
            TeacherDL.storeIntoFile(path, user);
            MessageBox.Show("Teacher has been added");
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
            grade.Text = "";
            username.Text = "";
            password.Text = "";

        }
    }
}
