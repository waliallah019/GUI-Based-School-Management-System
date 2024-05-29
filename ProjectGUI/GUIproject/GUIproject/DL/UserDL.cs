using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GUIproject.BL;
using System.Threading.Tasks;

namespace GUIproject.DL
{
    class UserDL
    {
        public static List<User> users = new List<User>();
        public static bool addUserIntoList(User user)
        {
            bool flag = true;
            users.Add(user);
            return flag;
        }
        public static bool removeUser(User u)
        {
            foreach (User u1 in users)
            {
                if (u.getUsername() == u1.getUsername() && u.getPassword() == u1.getPassword())
                {
                    users.Remove(u);
                    return true;
                }
            }
            return false;
        }
        public static void storeIntoFile(string path, User s)
        {
            if(s.getRole() == "Student")
            {
                StreamWriter f = new StreamWriter(path, true);
                f.WriteLine(s.getUsername() + "," + s.getPassword() + "," + s.getRole());
                f.Flush();
                f.Close();
            }
        }
        public static void updateFileData(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (User s in users)
            {
                f.WriteLine(s.getUsername() + "," + s.getPassword() + "," + s.getRole());
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
                    string username = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    User user = new User(username, password,role);
                    users.Add(user);
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
