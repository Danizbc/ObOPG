using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBLibary
{
    class Libary
    {
        //list of book named libarybooks
        List<Book> libaryBooks = new List<Book>();
        
        //object of books
        Book skyrimBook = new Book("Dragon Born");
        Book christmas = new Book("Santa on the edge");
        Book flatEarth = new Book("Flat earth.. when mama drop you on the head.");
        string printReturn;
        //Properties

        public Customer CustomerOne = new Customer("Bente");

        public List<Book> LibaryBooks
        {
            get { return libaryBooks; }
            set
            {
                libaryBooks = value;
            }
        }

        public string PrintReturn
        {
            get { return printReturn; }
            set
            {
                printReturn = value;
            }
        }

        //Constructor
        public Libary()
        {
            libaryBooks.Add(skyrimBook);
            libaryBooks.Add(skyrimBook = new Book("Dragon Born act II"));
            libaryBooks.Add(christmas);
            libaryBooks.Add(flatEarth);
        }
        //Print out list
        public string PrintList(List<Book> booklist)
        {
            PrintReturn = null;
            for (int i = 0; i < booklist.Count; i++)
            {
                PrintReturn += $"Book name = {booklist[i].BookName} -- Book ID = {i}.\n";
            }
            return PrintReturn;

        }

        //add book from libarybook list to customer.rentedbook stack and then return string.
        public string RentBook(int BookID)
        {
            if (libaryBooks.Count > 0)
            {
                Book temp = libaryBooks[BookID];
                libaryBooks.RemoveAt(BookID);
                CustomerOne.RentedBooks.Push(temp);
             
                return $"Book {temp.BookName} Rented";


            }
            else
            {
                return "No books left to rent.";
            }
           
        }
        //add book from list to stack and return string to print out
        public string ReturnBook()
        {
            if (CustomerOne.RentedBooks.Count > 0)
            {
                LibaryBooks.Add(CustomerOne.RentedBooks.Pop());
                return $"{CustomerOne.Name}.\n" +
                    $"You have returned the book called\n{LibaryBooks.Last().BookName}";
            }
            else
            {
                return "You have no rented books left.";
            }

        }


    }
}
