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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stID = 0;
            int stGrade = 0;
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
            if (Validations.IntValidation(grade.Text, 1, 10))
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
                    AccountsDL.AddFees(AccountsDL.accounts, s);
                    string path = "E:\\Assignments\\Project\\Data\\revenue_data.txt";
                    AccountsDL.storeIntoFile(path, AccountsDL.accounts.Revenue);
                    MessageBox.Show("Rs: "+s.Fees+" which is Fees of "+s.Name+" of Class "+s.Grade+" has been submitted");
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
