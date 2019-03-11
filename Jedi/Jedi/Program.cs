using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press [1] to see directonary.\nPress [2] to delete all non driods");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                switch (input.KeyChar)
                {
                    case '1':
                        Console.WriteLine(controller.Checker());
                        break;

                    case '2':
                        Console.WriteLine(controller.Deleting());
                        break;


                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Clear(); 
            }
        }
    }
}
