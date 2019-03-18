using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class SafeBox
    {
        //Attribute
        private string filepath = @".\Safebox.json";
        private string[] saveText = new string[1];
       
        /// <summary>
        /// input int create or append file 
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool Safe(int money)
        {
            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, $"Money in safebox {money} date = {DateTime.Now}.\n");

                return true;
            }
            else
            {
                File.AppendAllText(filepath, $"Money in safebox {money} date = {DateTime.Now}.\n");
                Console.Clear();
                return true;
            }
        }



    }
}
