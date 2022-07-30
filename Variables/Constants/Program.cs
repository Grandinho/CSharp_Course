using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    //Constants are immutable values which are known
    // at compile time and do not change for the life of the program.

    class Program
    {
        const double PI = 3.14159265;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string birthday = "01.02.2004";
        static void Main(string[] args)
        {
            // days = 366; //unpossible because its const 
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.ReadLine();
        }
    }
}
