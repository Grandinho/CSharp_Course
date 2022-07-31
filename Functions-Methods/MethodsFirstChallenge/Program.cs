using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friendName1 = "Alferd";
            string friendName2 = "John";
            string friendName3 = "Alfonso";
            GreetFriends(friendName1);
            GreetFriends(friendName2);
            GreetFriends(friendName3);
            Console.ReadLine();

        }

        static void GreetFriends(string _friendName)
        {
            Console.WriteLine("Hi {0}, my friend!", _friendName);
        }
    }
}
