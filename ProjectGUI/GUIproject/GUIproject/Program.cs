using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIproject.DL;
using GUIproject.BL;

namespace GUIproject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string status1;
            string status2;
            string status3;
            string status4;
            string status5;
            string status6;
            string path1 = "E:\\Assignments\\Project\\Data\\student_data.txt";
            bool check1 = StudentDL.readFromFile(path1);
            if (check1)
            {
                status1 = "Student Data has been loaded";
            }
            else
            {
                status1 = "Student Data has not been loaded";
            }
            string path2 = "E:\\Assignments\\Project\\Data\\teacher_data.txt";
            bool check2 = TeacherDL.readFromFile(path2);
            if (check2)
            {
                status2 = "Teacher Data has been Loaded";
            }
            else
            {
                status2 = "Teacher Data has not been Loaded";
            }
            string path3 = "E:\\Assignments\\Project\\Data\\admin_data.txt";
            bool check3 = AdminDL.readFromFile(path3);
            if (check3)
            {
                status3 = "Admin Data has been Loaded";
            }
            else
            {
                status3 = "Admin Data has not been Loaded";
            }
            string path5 = "E:\\Assignments\\Project\\Data\\revenue_data.txt";
            bool check5 = AccountsDL.readFromFile(path5);
            if (check5)
            {
                status5 = "Revenue Data has been Loaded";
            }
            else
            {
                status5 = "Revenue Data has not been Loaded";
            }
            string path4 = "E:\\Assignments\\Project\\Data\\expense_data.txt";
            List<Expense> expenses = ExpenseDL.readFromFile(path4,AccountsDL.accounts);
            bool check4 = false;
            {
                if(expenses!=null)
                {
                    check4 = true;
                }
            }
            if (check4)
            {
                status4 = "Expenses Data has been Loaded";
            }
            else
            {
                status4 = "Expenses Data has not been Loaded";
            }
            string path6 = "E:\\Assignments\\Project\\Data\\announcements.txt";
            bool check6 = TeacherDL.readAnnouncementFromFile(path6);
            if (check6)
            {
                status6 = "Announcement Data has been Loaded";
            }
            else
            {
                status6 = "Announcement Data has not been Loaded";
            }
            MessageBox.Show(status1 + "\n" + status2 + "\n" + status3 + "\n" + status4 + "\n" + status5 + "\n" + status6 + "");
            Application.Run(new logIn());
        }
    }
}
