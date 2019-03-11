using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObPrimalTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();

             
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Option.\nPress [1] to print name queue.\nPress [2] Add random names.\nPress [3] to delete the hole list.");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                switch (input.KeyChar)
                {
                    case '1':
                        Console.WriteLine(logic.PrintNames());
                        break;

                    case '2':
                        logic.AddNames();
                        Console.WriteLine("Names added");
                        break;

                    case '3':
                        logic.DeleteQueueInFakta();
                        Console.WriteLine("Queue deleted");
                        break;

                    default:
                        Console.WriteLine("Something went wrong, now we have to do it alllllll over again.............");
                        break;
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }





        }
    }
}
