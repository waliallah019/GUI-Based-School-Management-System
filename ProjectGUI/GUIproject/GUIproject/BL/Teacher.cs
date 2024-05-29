using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.DL;

namespace GUIproject.BL
{
    class Teacher : User
    {
        private string name;
        private char gender;
        private string DOB;
        private string contactNo;
        private int ID;        
        private double salary;
        private int grade;
        private string announcement;
        public Teacher(string name,char gender, string DOB, string contactNo, int ID, string role, string username, string password, int grade, double salary) : base(username, password, role)
        {
            this.name = name;
            this.gender = gender;
            this.DOB = DOB;
            this.contactNo = contactNo;
            this.ID = ID;
            this.Salary = salary;
            this.Grade = grade;
        }

        public double Salary
        {
            get => salary;
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
            }
        }
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
        public string Announcement { get => announcement; set => announcement = value; }

        public bool makeAnnouncement()
        {
            bool flag = false;
            return flag;
        }
    }
}
