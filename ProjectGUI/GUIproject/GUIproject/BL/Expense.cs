using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIproject.BL
{
    class Expense
    {
        private string name;
        private double price;

        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        public string Name { get => name; set => name = value; }
        public Expense(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
