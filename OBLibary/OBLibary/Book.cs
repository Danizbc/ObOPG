using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBLibary
{
    class Book
    {
        //Attribute
        private string bookName;

        //Properties
        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
            }
        }


        //constructor
        public Book(string aBookName)
        {
            BookName = aBookName;
        }
    }
}
