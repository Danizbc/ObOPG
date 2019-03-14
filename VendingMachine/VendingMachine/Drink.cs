using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Drink : Product
    {
        //Atributes
        private double liter;

        //Properties
        public double Liter
        {
            get
            {
                return liter;
            }
            set
            {
                liter = value;
            }
        }

        //Constructor
        public Drink(string DrinkName, int DrinkPrice, double DrinkLiter)
        {
            Name = DrinkName;
            Price = DrinkPrice;
            Liter = DrinkLiter;
            ID = 1;
        }
    }
}
