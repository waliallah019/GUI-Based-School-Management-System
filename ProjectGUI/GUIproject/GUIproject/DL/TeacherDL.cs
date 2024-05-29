using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.BL;
using System.IO;


namespace GUIproject.DL
{
    class TeacherDL
    {
        public static List<Teacher> teachers = new List<Teacher>();
        public static List<string> announcements = new List<string>();
        public static bool addTeacherIntoList(Teacher teacher)
        {
            bool flag = true;
            teachers.Add(teacher);
            return flag;
        }
        public static bool addAnnouncementIntoList(String announcement)
        {
            bool flag = true;
            announcements.Add(announcement);
            return flag;
        }
        public static bool removeTeacher(Teacher t)
        {
            foreach (Teacher t1 in teachers)
            {
                if (t.ID1 == t1.ID1 && t.Grade == t1.Grade)
                {
                    teachers.Remove(t);
                    return true;
                }
            }
            return false;
        }
        public static Teacher findTeacher(User u1)
        {
            foreach (Teacher teacher in teachers)
            {
                if (u1.getUsername() == teacher.getUsername() && u1.getPassword() == teacher.getPassword())
                {
                    return teacher;
                }
            }
            return null;
        }
        public static void storeAnnouncementIntoFile(string path, string announcement)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(announcement);
            f.Flush();
            f.Close();
        }
        public static void storeIntoFile(string path, Teacher s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.Name + "," + s.Gender + "," + s.DOB1 + "," + s.ContactNo + "," + s.ID1 + "," + s.getRole() + "," + s.getUsername() + "," + s.getPassword() + "," + s.Grade + "," + s.Salary);
            f.Flush();
            f.Close();
        }
        public static void updateFileData(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Teacher s in teachers)
            {
                f.WriteLine(s.Name + "," + s.Gender + "," + s.DOB1 + "," + s.ContactNo + "," + s.ID1 + "," + s.getUsername() + "," + s.getPassword() + "," + s.Grade + "," + s.Salary);
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
                    int grade = int.Parse(splittedRecord[8]);
                    double salary = double.Parse(splittedRecord[9]);
                    User s = new Teacher(name,gender, DOB, contactNo,ID, role, username, password, grade, salary);
                    Teacher s1 = new Teacher(name, gender, DOB, contactNo,ID, role, username, password, grade, salary);
                    User u = new User(username, password, "Teacher");
                    UserDL.users.Add(u);
                    TeacherDL.teachers.Add(s1);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool readAnnouncementFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string announcement = record;
                    announcements.Add(announcement);
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
