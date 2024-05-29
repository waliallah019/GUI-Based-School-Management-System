using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GUIproject.BL;

namespace GUIproject.DL
{
    class StudentDL
    {
        public static List<Student> students = new List<Student>();
        public static Student findStudent(int id, int grade)
        {
            foreach (Student student in students)
            {
                if (id == student.ID1 && grade == student.Grade)
                {
                    return student;
                }
            }
            return null;
        }
        public static bool addStudentIntoList(Student student)
        {
            bool flag = true;
            students.Add(student);
            return flag;
        }
        public static bool removeStudent(Student s)
        {
            foreach (Student s1 in students)
            {
                if (s.ID1 == s1.ID1 && s.Grade == s1.Grade)
                {
                    students.Remove(s);
                    return true;
                }
            }
            return false;
        }
        public static void storeIntoFile(string path, Student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.Name + ","+ s.Gender + "," + s.DOB1 + "," + s.ContactNo + "," + s.ID1 + "," +s.getRole()+","+ s.getUsername() + "," + s.getPassword() + "," + s.FatherProfession + "," + s.Grade + "," + s.Fees);
            f.Flush();
            f.Close();
        }
        public static void updateFileData(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Student s in students)
            {
                f.WriteLine(s.Name + "," + s.Gender + "," + s.DOB1 + "," + s.ContactNo + "," + s.ID1 + "," + s.getRole() + "," + s.getUsername() + "," + s.getPassword() + "," + s.FatherProfession + "," + s.Grade + "," + s.Fees);
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
                    string fatherProfession = splittedRecord[8];
                    int grade = int.Parse(splittedRecord[9]);
                    double fees = double.Parse(splittedRecord[10]);
                    User s = new Student(name,gender, DOB, contactNo, ID, role, username, password, fatherProfession, grade, fees);
                    Student s1 = new Student(name, gender, DOB, contactNo, ID, role, username, password, fatherProfession, grade, fees);
                    User u = new User(username, password, "Student");
                    UserDL.users.Add(u);
                    StudentDL.students.Add(s1);
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
