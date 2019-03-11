using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FIFO
{
    class Guest
    {

        //Attributes
        string name;
        int age;

        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }


        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        //Constructor
        public Guest(string Uname, int Uage)
        {
            Name = Uname;
            Age = Uage;
        }
    }
}
