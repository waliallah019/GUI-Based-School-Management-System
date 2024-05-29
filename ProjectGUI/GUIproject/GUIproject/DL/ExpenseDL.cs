using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.BL;
using System.IO;

namespace GUIproject.DL
{
    class ExpenseDL
    {
        public static List<Expense> expenses = new List<Expense>();
        public static bool addExpenseIntoList(Expense e)
        {
            bool flag = true;
            expenses.Add(e);
            return flag;
        }
        public static void storeIntoFile(string path, Expense e)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(e.Name + "," + e.Price);
            f.Flush();
            f.Close();
        }
        public static void updateFileData(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Expense e in expenses)
            {
                f.WriteLine(e.Name + "," + e.Price);
            }
            f.Flush();
            f.Close();
        }
        public static List<Expense> readFromFile(string path,Accounts accounts)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int price = int.Parse(splittedRecord[1]);
                    Expense expense = new Expense(name, price);
                    expenses.Add(expense);
                    accounts.addExpense(expense);
                }
                f.Close();
                return expenses;
            }
            else
            {
                return null;
            }
        }

    }
}
