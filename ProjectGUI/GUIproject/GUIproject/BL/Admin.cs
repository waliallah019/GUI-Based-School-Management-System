using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIproject.BL
{
    class Admin : User
    {
        private string name;
        private char gender;
        private string DOB;
        private string contactNo;
        private int ID;
        private double salary;
        public Admin(string name, char gender, string DOB, string contactNo,int ID, string role, string username, string password, double salary) : base(username, password,role)
        {
            this.name = name;
            this.gender = gender;
            this.DOB = DOB;
            this.contactNo = contactNo;
            this.ID = ID;
            this.salary = salary;
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
        public string Name { get => name; set => name = value; }
        public char Gender { get => gender; set => gender = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public int ID1 { get => ID; set => ID = value; }
        public bool manageAccounts()
        {
            bool flag = false;
            return flag;
        }
    }
}
