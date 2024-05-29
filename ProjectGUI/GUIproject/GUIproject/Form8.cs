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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stName = name.Text;
            Char stGender = char.Parse(gender.Text);
            string stDOB = DOB.Text;
            string stContactNo = contactNo.Text;
            int stID=0;
            int stGrade = 0;
            double stFees = 0;
            if (Validations.IntValidation(id.Text))
            {
                stID = int.Parse(id.Text);
                
            }
            else
            {
                id.Text = "";
                MessageBox.Show("Error: Id can only be integer\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validations.DoubleValidation(fees.Text))
            {
                stFees = double.Parse(fees.Text);

            }
            else
            {
                fees.Text = "";
                MessageBox.Show("Error: Fees can only be in numbers\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validations.IntValidation(grade.Text,1,10))
            {
                stGrade = int.Parse(grade.Text);
            }
            else
            {
                grade.Text = "";
                MessageBox.Show("Error: Grade can only be integer and between 1 and 10\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            
            foreach (Student s in StudentDL.students)
            {
                if (s.ID1 == stID && s.Grade == stGrade)
                {
                    MessageBox.Show("Error: A student with same id and grade already exists\n Renter Data","Recurrsion Error",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                    grade.Text = "";
                    id.Text = "";
                    ClearDataFromForm();
                    return;
                }
            }
            string stFatherProfession = fatherProfession.Text;
            string stUsername = username.Text;
            string stPassword = password.Text;
            foreach(User s in UserDL.users)
            {
                if(s.getUsername() == stUsername)
                {
                    MessageBox.Show("Error: Same username already exists in the system\nRenter Data", "Recurrsion Error",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                    ClearDataFromForm();
                    return;
                }
            }
            
            Student user = new Student(stName,stGender, stDOB, stContactNo, stID, "Student", stUsername, stPassword, stFatherProfession, stGrade, stFees);
            StudentDL.addStudentIntoList(user);
            string path = "E:\\Assignments\\Project\\Data\\student_data.txt";
            StudentDL.storeIntoFile(path, user);
            MessageBox.Show("Student has been added");
            ClearDataFromForm();
        }
        private void ClearDataFromForm()
        {
            name.Text = "";
            gender.Text = "";
            DOB.Text = "";
            contactNo.Text = "";
            id.Text = "";
            fees.Text = "";
            grade.Text = "";
            fatherProfession.Text = "";
            username.Text = "";
            password.Text = "";

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
