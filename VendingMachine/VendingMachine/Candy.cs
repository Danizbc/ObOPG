using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Candy : Product
    {
        //Attribute
        private string size;

        //Properties
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        //Constructor
        public Candy(string CandyName, int CandyPrice, string CandySize)
        {
            Name = CandyName;
            Price = CandyPrice;
            size = CandySize;
            ID = 0;
        }
    }
}
