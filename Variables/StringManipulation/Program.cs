using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 31;
            string name = "Akosczuel";

            // 1. string concatenation
            Console.WriteLine("String Concatetation");
            Console.WriteLine("Hello my name is " + name + "I am " + age + " years old");

            // 2. String formatting
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old", name, age);

            //3. String interpolation
            //string Interpolation uses $ at the start which allow us to write our
            //variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            //4. Verbatim strings.
            //verbatim string start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like  \n
            Console.WriteLine(@"C:\users\name\documents");
            Console.WriteLine("C:\users\name\documents"); //doesnt work because of backslashes


            Console.ReadKey();
        }
    }
}
