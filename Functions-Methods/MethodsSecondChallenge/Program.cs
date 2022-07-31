using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSecondChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LowUpper("Lol"));
            Count("Lol");
            Console.ReadLine();
        }

        //1. LowUpper method will take a string as input,
        //create lower- and uppercase copies,
        //and return the result of their join.
        public static string LowUpper(string _myString)
        {
            string _myStringLower = _myString.ToLower();
            string _myStringUpper = _myString.ToUpper();
            return string.Concat(_myStringLower,_myStringUpper);

        }

        //2. The Count method also will take a string,
        //but it will not return.
        //It only will print "The amount of characters is X."
        //with X replaced with the actual amount of characters
        //in the string on another line.
        
        public static void Count(string _myString)
        {
            Console.WriteLine("The ammount of characters is {0}", _myString.Count());
        }
    }
}
