using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controll = new Controller();

            //Run program until you close it :DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press [1] to see guest list.\nPress [2] to let one guest in.\nPress [3] to see quest inside.\nPress [4] to kick first guest");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                switch (char.ToLower(input.KeyChar))
                {
                    case '1':
                        Console.WriteLine(controll.PrintGuestList());
                        break;

                    case '2':
                        Console.WriteLine(controll.LetOneGuestIn());
                        break;

                    case '3':
                        Console.WriteLine(controll.PrintGuestInside());
                        break;

                    case '4':
                        Console.WriteLine(controll.KickFirstGuest());
                        break;

                    default:

                        break;
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadLine();
            }

        }
    }
}
