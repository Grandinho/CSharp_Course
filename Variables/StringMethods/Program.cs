using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Denis";
            string lastName = "Panjuta";
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(firstName.Substring(2)); //output: "nis"
            Console.WriteLine(firstName.ToLower()); //output: "denis"
            Console.WriteLine(firstName.ToUpper()); //output: "DENIS"
            Console.WriteLine(fullName.Trim()); //output: "DenisPanjuta" 
            Console.WriteLine(firstName.IndexOf('e')); //output: 1
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); //output: false
            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
