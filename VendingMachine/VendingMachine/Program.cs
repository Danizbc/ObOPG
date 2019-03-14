using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
      
            VendingMachine vending = new VendingMachine();


            vending.FillProduct();

     
           

            Console.WriteLine(vending.PushProduct(2, 25));


            Console.ReadKey();
        }
    }
}
