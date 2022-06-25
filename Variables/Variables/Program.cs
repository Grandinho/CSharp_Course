using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;

            // assigning a value to a variable
            num1 = 13;

            //declaring and initializing a variable in one go
            int num2 = 23;
       
            int sum = num1 + num2;
            Console.WriteLine(sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine(dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine(fDiv);
        }
    }
}
