using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObOPG
{
    class Program
    {
        //GG
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;

            Washer WashMachine = new Washer();



            Console.WriteLine("Press [o] to turn on Washing Machine");

            input = Console.ReadKey();
            Console.Clear();
            if (char.ToLower(input.KeyChar) == 'o')
            {
                WashMachine.PowerButton = true;

                while (WashMachine.PowerButton == true)
                {
                    string tempInfo;
                    string tempInfo2;
                    //Printing out washing program strign
                    Console.WriteLine(WashMachine.ProgramString());
                    
                    //Giving user option top pick wash program.
                    input = Console.ReadKey();
                    Console.Clear();
                    //Sending input and returning 2 strings. first string if correct input says washing please wait. secound string done
                    WashMachine.WashProgram(input.KeyChar, out tempInfo, out tempInfo2);
                    Console.WriteLine(tempInfo);
                    Thread.Sleep(4000);
                    Console.WriteLine(tempInfo2);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Auto Powering off");
                Thread.Sleep(2000);
            }

     
        }
    }
}
