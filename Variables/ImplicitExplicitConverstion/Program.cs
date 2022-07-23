using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicitConverstion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit Converstion

            double myDouble = 13.37;
            int myInt;

            // cast double to int
            myInt = (int)myDouble;


            //Implicit Converstion

            int num = 21321321;
            long bigNum = num;

            float myFlaot = 13.321f;
            double myNewDouble = myFlaot;

            //Type converstion

            string myString = myDouble.ToString();
            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();

        }
    }
}
