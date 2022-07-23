using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("Enter a string and press enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and press enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();

        }
    }
}
