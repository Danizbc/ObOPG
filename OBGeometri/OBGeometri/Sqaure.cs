using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBGeometri
{
    public class Sqaure
    {
        //Attribute
        private double a;
        private double result;


        //Properties
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }



        //constructor
        public Sqaure()
        {
            

        }



        //Methods
        public void SquareCalculate()
        {
            this.Result = 4 * this.a;
            
        }

        public void AreaCaluculate()
        {

            this.Result = Math.Pow(a,2);

        }



    }
}
