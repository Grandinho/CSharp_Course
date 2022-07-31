using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Some message");
            Console.ReadLine();
        }

        //Access modifier (static) return type method name(params)
        //Void method without parameters
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");

        }

        //Access modifier (static) return type method name(params)
        //Voide method with parameters
        public static void WriteSomethingSpecific(string _message)
        {
            Console.WriteLine(_message);
        }
    }
}
