using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.BL;
using System.IO;


namespace GUIproject.DL
{
    class AccountsDL
    {
        public static void AddFees(Accounts a, Student s)
        {
            a.Revenue = a.Revenue + s.Fees;
        }
        public static Accounts accounts = new Accounts();
        public static Expense paySalary(Accounts a, Teacher t, string path)
        {
            a.Revenue = a.Revenue - t.Salary;
            string expenseName = "The slary of Teacher: " + t.Name;
            double expenseValue = t.Salary;
            Expense expense = new Expense(expenseName, expenseValue);
            ExpenseDL.addExpenseIntoList(expense);
            ExpenseDL.storeIntoFile(path, expense);
            return expense;
        }

        public static Expense paySalary(Accounts a, Admin ad, string path)
        {
            Console.WriteLine("The salary of " + ad.Name + " is " + ad.Salary + "");
            a.Revenue = a.Revenue - ad.Salary;
            string expenseName = "The slary of Admin: " + ad.Name;
            double expenseValue = ad.Salary;
            Expense expense = new Expense(expenseName, expenseValue);
            ExpenseDL.addExpenseIntoList(expense);
            ExpenseDL.storeIntoFile(path, expense);
            return expense;
        }
        public static void storeIntoFile(string path, double revenue)
        {
            StreamWriter f = new StreamWriter(path);
            f.WriteLine(revenue);
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            double record;
            if (File.Exists(path))
            {
                record = double.Parse(f.ReadLine());
                accounts.Revenue = record;
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
