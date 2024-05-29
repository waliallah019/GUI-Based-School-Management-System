using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIproject.BL
{
    class Accounts
    {
        private static List<Expense> expenses = new List<Expense>();
        private double revenue;

        public bool addExpense(Expense expense)
        {
            Expenses.Add(expense);
            return true;
        }
        
        public double Revenue { get => revenue; set => revenue = value; }
        internal static List<Expense> Expenses { get => expenses; set => expenses = value; }
    }
}
