using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi
{
    class Controller
    {
        Dictionary<string, bool> people = new Dictionary<string, bool>();
        Dictionary<string, bool> driods = new Dictionary<string, bool>();
        private string printerString = "";

        public Controller()
        {
            people.Add("Luke", true);
            people.Add("Leia", false);
            people.Add("Han", false);
            people.Add("Yoda", false);
            people.Add("chewbacca", false);


            driods.Add("r2d2", true);
            driods.Add("r1d1", true);
            driods.Add("chewbacca", false);
            driods.Add("luke", false);

        }


        public string Checker()
        {
            printerString = null;
            foreach (KeyValuePair<string, bool> pair in people)
            {
                if (pair.Value)
                {
                    printerString += pair.Key + " Is a jedi \n\n";
                }
                else
                {
                    printerString += pair.Key + " Is not a jedi\n\n";
                }
            }


            foreach (KeyValuePair<string, bool> pair in driods)
            {

                if (pair.Value)
                {
                    printerString += pair.Key + "is a driod\n\n";
                }
                else
                {
                    printerString += pair.Key + "is not a driod\n\n";
                }

            }

            return printerString;
        }


        public string Deleting()
        {
            List<string> deletingnames = new List<string>();
            printerString = null;
            printerString += "Deleting\n\n";
            foreach (KeyValuePair<string, bool> pair in driods)
            {
                if (pair.Value)
                {
                    printerString += $"{pair.Key} not removed\n\n";

                }
                else
                {
                    printerString += $"{pair.Key} got removed becuase it's not a driod\n\n";
                    deletingnames.Add(pair.Key);
                }



            }
            for (int i = 0; i < deletingnames.Count; i++)
            {

                driods.Remove(deletingnames[i]);
            }


            return printerString;
        }

    }
}
