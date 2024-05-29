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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int spending = 0;
            if (Validations.IntValidation(price.Text))
            {
                spending = int.Parse(price.Text);

            }
            else
            {
                price.Text = "";
                MessageBox.Show("Error: Price can only be integer\n Renter Data", "Recurrsion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string path = "E:\\Assignments\\Project\\Data\\expense_data.txt";
            Expense expense = new Expense(type.Text, double.Parse(price.Text));
            ExpenseDL.addExpenseIntoList(expense);
            ExpenseDL.storeIntoFile(path, expense);
            Accounts.Expenses.Add(expense);
            AccountsDL.accounts.Revenue = AccountsDL.accounts.Revenue - expense.Price;
            string path1 = "E:\\Assignments\\Project\\Data\\revenue_data.txt";
            AccountsDL.storeIntoFile(path1, AccountsDL.accounts.Revenue);
            MessageBox.Show("Rs: " + expense.Price + " for " + expense.Name + " has been payed");
            ClearDataFromForm();
        }
        private void ClearDataFromForm()
        {
            type.Text = "";
            price.Text = "";
        }

    }
}
