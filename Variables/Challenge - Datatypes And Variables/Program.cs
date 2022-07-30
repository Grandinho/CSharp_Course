using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge___Datatypes_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 255;
            sbyte mySbyte = 127;
            int myInt = -3213213;
            int myUInt = 231321;
            float myFlaot = 0.432f;
            double myDouble = 23.32;
            char myChar = 'A';
            bool myBool = true;

            string myText = "I control text";
            string numText = "15";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
        }
    }
}
