using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObOPG
{
    class Washer
    {
        //Attributes
        private readonly string name;

        private string programName;

        private int time = 0;

        private bool powerButton = false;


        //Properties

        public bool PowerButton
        {
            get
            {
                return powerButton;
            }
            set
            {
                powerButton = value;
            }
        }

        //Constructor
        public Washer()
        {
            name = "Wash2.0";
            PowerButton = false;
            time = 0;
            
        }


        //Methods

        public void Power()
        {
            powerButton = true;
        }

        //Method

            /// <summary>
            /// Inputs 1-4 for programs. o to power off. 2 string outputs to print
            /// </summary>
            /// <param name="type"></param>
            /// <param name="output"></param>
            /// <param name="output2"></param>
        public void WashProgram(char type, out string output, out string output2)
        {

            switch (type)
            {
                case '1':
                    programName = "Fill";
                    time = 20;
                    output = "Washing Please wait";
                    output2 = "Done\nPress any key to continue";
                    break;
                case '2':
                    programName = "Wash";
                    time = 50;
                    output = "Washing Please wait";
                    output2 = "Done\nPress any key to continue";
                    break;
                case '3':
                    programName = "eco";
                    time = 30;
                    output = "Washing Please wait";
                    output2 = "Done\nPress any key to continue";
                    break;
                case '4':
                    programName = "Spin";
                    time = 45;
                    output = "Washing Please wait";
                    output2 = "Done\nPress any key to continue";
                    break;
                case 'o':
                    powerButton = false;
                    output = "Powering off";
                    output2 = "bye";
                    break;
                default:
                    output = "No program with that id";
                    output2 = "Press any key to continue";
                    break;
            }

        }


        public string ProgramString()
        {
            return "Wash2.0 Options\nFill Program [1].\nWash Program [2]\nEco Program[3]\nSpin Program [4]\nPower off [o]";
        }
    }
}
