using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(32, 32));
            Console.WriteLine(Multiply(32, 32));
            Console.WriteLine(Divide(29, 3));
            Console.ReadLine();
            
        }

        //Method with integer return value that add up 2 numbers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method with integer return value that multiplies 2 numbers
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //Method with double return value that divides 2 numbers
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
