using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBLibary
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = "Wrong input try again";

            //Creating object of libary.
            Libary libary = new Libary();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Bastopia Libary we have alot of books to rent.\n" +
                        "Press [1] rent a book.\nPress [2] to return book");
                ConsoleKeyInfo input = Console.ReadKey(); ;
                Console.Clear();
                //Switch case 1 for rent 2 for return book. using libary.
                switch (input.KeyChar)
                {
                    case '1':


                        try
                        {
                           
                            Console.WriteLine(libary.PrintList(libary.LibaryBooks));
                            Console.WriteLine("Write book id of the book you want to rent");
                            int bookID;
                            bookID = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(libary.RentBook(bookID));
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                     
                        break;

                    case '2':
                        Console.WriteLine(libary.ReturnBook());
                        break;

                    default:
                        Console.WriteLine(error);
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

        }
    }
}
