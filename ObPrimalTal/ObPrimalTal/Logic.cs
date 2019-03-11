using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObPrimalTal
{
    class Logic
    {
        //Attribute
        Queue<string> names = new Queue<string>();
        List<string> namelist = new List<string>() {"Dennis","Benny","Bent","Carla","Dom","Karla","René","Zanta" };
        Random ran = new Random();
        //Properties
        public Queue<string> Names
        {
            get { return names; }
            set
            {
                names = value;
            }
        }
        //Constructor
        public Logic()
        {
            names.Enqueue("Daniel");
            names.Enqueue("Peter");
            names.Enqueue("Bente");
            names.Enqueue("Julz");
        }
        //Methods

        public void DeleteQueueInFakta()
        {
            while (Names.Count > 0)
            {
                names.Dequeue();
            }
        }

        public void AddNames()
        {
            while (names.Count < 5)
            {
                names.Enqueue(namelist[ran.Next(0,namelist.Count)]);
            }
        }

        public string PrintNames()
        {
            string temp = "";
            while (Names.Count > 0)
            {
                temp += $"{Names.Dequeue()}\n";
            }
            return temp;
        }

    }
}
