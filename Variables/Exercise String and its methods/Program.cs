using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_String_and_its_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercie 1
            string userName;

            Console.Write("Please enter your name and press enter ");
            userName = Console.ReadLine();

            string userNameUpperCase = string.Format("Upper case: {0}", userName.ToUpper());
            Console.WriteLine(userNameUpperCase);
            Console.WriteLine(userName.ToLower());
            Console.WriteLine(userName.Trim());
            Console.WriteLine(userName.Substring(0,5));

        

            //Exercise 2.a
            Console.Write("Enter a string here: ");
            string myString = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            char searchCharacter = Console.ReadLine()[0];

            string characterIndex = string.Format("The index of the first occurrence of the searched character: {0}", myString.IndexOf(searchCharacter));
            Console.WriteLine(characterIndex);


            //Exercise 2.b
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            Console.ReadKey();



        }
    }
}
