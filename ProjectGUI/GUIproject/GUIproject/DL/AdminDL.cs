using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.BL;
using System.IO;


namespace GUIproject.DL
{
    class AdminDL
    {
        public static List<Admin> admins = new List<Admin>();

        public static Admin findAdmin(User u1)
        {
            foreach (Admin admin in admins)
            {
                if (u1.getUsername() == admin.getUsername() && u1.getPassword() == admin.getPassword())
                {
                    return admin;
                }
            }
            return null;
        }
        public static bool addAdminIntoList(Admin admin)
        {
            bool flag = true;
            admins.Add(admin);
            return flag;
        }
        public static bool removeAdmin(Admin a)
        {
            foreach (Admin a1 in admins)
            {
                if (a.ID1 == a1.ID1 && a.getUsername() == a1.getUsername() && a.getPassword() == a1.getPassword())
                {
                    admins.Remove(a);
                    return true;
                }
            }
            return false;
        }
        public static void storeIntoFile(string path, Admin s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.Name + ","+ s.Gender + "," + s.DOB1 + "," + s.ContactNo + ","  + s.ID1 + "," + s.getRole() + "," + s.getUsername() + "," + s.getPassword() + "," + s.Salary);
            f.Flush();
            f.Close();
        }
        public static void updateFileData(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Admin s in admins)
            {
                f.WriteLine(s.Name + "," + s.Gender + "," + s.DOB1 + "," + s.ContactNo + "," + s.ID1 + "," + s.getRole() + "," + s.getUsername() + "," + s.getPassword() + "," + s.Salary);
            }
            f.Flush();
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    char gender = char.Parse(splittedRecord[1]);
                    string DOB = splittedRecord[2];
                    string contactNo = splittedRecord[3];
                    int ID = int.Parse(splittedRecord[4]);
                    string role = splittedRecord[5];
                    string username = splittedRecord[6];
                    string password = splittedRecord[7];
                    double salary = double.Parse(splittedRecord[8]);
                    User admin = new Admin(name,gender, DOB, contactNo,ID, role, username, password, salary);
                    Admin admin1 = new Admin(name,gender, DOB, contactNo, ID, role, username, password, salary);
                    AdminDL.addAdminIntoList(admin1);
                    User u = new User(username, password, "Admin");
                    UserDL.users.Add(u);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
