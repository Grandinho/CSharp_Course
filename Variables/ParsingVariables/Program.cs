using System;

namespace ParsingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);

            int result1 = num1 + num2;

            Console.WriteLine(result1);
            Console.Read();

            //Exercise 1

            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float numForFloat = float.Parse(stringForFloat);
            int numForInt = int.Parse(stringForInt);

            
        }
    }
}
