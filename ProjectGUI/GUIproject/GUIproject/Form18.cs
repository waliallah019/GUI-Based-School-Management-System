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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tID = 0;
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
                    string path = "E:\\Assignments\\Project\\Data\\expense_data.txt";
                    Expense expense = AccountsDL.paySalary(AccountsDL.accounts,s,path);
                    Accounts.Expenses.Add(expense);
                    string path1 = "E:\\Assignments\\Project\\Data\\revenue_data.txt";
                    AccountsDL.storeIntoFile(path1, AccountsDL.accounts.Revenue);
                    MessageBox.Show("Rs: " + s.Salary + " which is Salary of " + s.Name + " of Class " + s.Grade + " has been payed");
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
            grade.Text = "";
        }

    }
}
