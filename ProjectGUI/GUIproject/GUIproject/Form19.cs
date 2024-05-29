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
    public partial class Form19 : Form
    {
        public Form19()
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
                if (s.ID1 == aID && s.getUsername() == username.Text)
                {
                    string path = "E:\\Assignments\\Project\\Data\\admin_data.txt";
                    Expense expense = AccountsDL.paySalary(AccountsDL.accounts, s, path);
                    Accounts.Expenses.Add(expense);
                    string path1 = "E:\\Assignments\\Project\\Data\\revenue_data.txt";
                    AccountsDL.storeIntoFile(path1, AccountsDL.accounts.Revenue);
                    MessageBox.Show("Rs: " + s.Salary + " which is Salary of Admin " + s.Name + " has been payed");
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
        }


    }
}
