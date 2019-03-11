using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBLibary
{
    class Customer
    {
        //Attribute
        private string name;

        private Stack<Book> rentedBooks = new Stack<Book>();


        //Properties

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Stack<Book> RentedBooks
        {
            get { return rentedBooks; }
            set
            {
                rentedBooks = value;
            }
        }


        //constructor

        public Customer(string Pname)
        {
            Name = Pname;
        }



    }
}
