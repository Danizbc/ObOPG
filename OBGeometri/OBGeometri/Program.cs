using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBGeometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Sqaure sqaure = new Sqaure();
            Sqaure sqaure2 = new Sqaure();

            sqaure.A = 20;
            sqaure2.A = 30;

            Console.WriteLine($"Calculate squares\nFirst square");

            sqaure.SquareCalculate();

            Console.WriteLine(sqaure.Result);


            Console.WriteLine("Calculating secound square");

            sqaure2.SquareCalculate();

            Console.WriteLine(sqaure2.Result);
            
               
            sqaure = new Sqaure();

            sqaure.A = 24;

            Console.WriteLine("Area calculate");

            sqaure.AreaCaluculate();

            Console.WriteLine(sqaure.Result);

            Console.ReadKey();

        }
    }
}
