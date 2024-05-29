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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int tGrade = 0;   
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
            string announcement = "For class: " + grade.Text + " Announcement: " + textBox2.Text;
            string path = "E:\\Assignments\\Project\\Data\\announcements.txt";
            TeacherDL.addAnnouncementIntoList(announcement);
            TeacherDL.storeAnnouncementIntoFile(path, announcement);
            MessageBox.Show("Announcement has been made");
            ClearDataFromForm();
        }
        private void ClearDataFromForm()
        {
            grade.Text = "";
            textBox2.Text = "";
        }
    }
}
