using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUIproject.DL;
using System.Threading.Tasks;

namespace GUIproject.BL
{
    class Student : User
    {
        private string name;
        private char gender;
        private string DOB;
        private string contactNo;
        private int ID;        
        private string fatherProfession;
        private int grade;
        private double fees;
        public Student(string name,char gender, string DOB, string contactNo, int ID, string role, string username, string password, string fatherProfession, int grade, double fees) : base(username, password,role)
        {
            this.name = name;
            this.gender = gender;
            this.DOB = DOB;
            this.contactNo = contactNo;
            this.ID = ID;
            this.FatherProfession = fatherProfession;
            this.Grade = grade;
            this.Fees = fees;
        }

        public double Fees
        {
            get => fees;
            set
            {
                if (value > 0)
                {
                    fees = value;
                }
            }
        }

        public string FatherProfession { get => fatherProfession; set => fatherProfession = value; }
        public int Grade
        {
            get => grade;
            set
            {
                if (value > 0 && value < 11)
                {
                    grade = value;
                }
            }
        }

        public string Name { get => name; set => name = value; }
        public char Gender { get => gender; set => gender = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public int ID1 { get => ID; set => ID = value; }

        public bool isStudentExists(Student s)
        {
            foreach (Student stu in StudentDL.students)
            {
                if (stu.ID == s.ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
