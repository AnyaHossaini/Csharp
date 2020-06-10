using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeVr 
{
    class varaiblePractice 
    {
        static void Main(string[]args)
        {
            byte number =2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Anya";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // You can name all variables in C# as var instead of an actual type and C# will figure out the type

            var number1 =2;
            var count1 = 10;
            var totalPrice1 = 20.95f;
            var character1 = 'A';
            var firstName1 = "Anya";
            var isWorking1 = false;

            Console.WriteLine(number1);
            Console.WriteLine(count1);
            Console.WriteLine(totalPrice1);
            Console.WriteLine(character1);
            Console.WriteLine(firstName1);
            Console.WriteLine(isWorking1);

            //This is a format string --> Used as a template
            Console.WriteLine("{0}{1}", byte.MinValue, byte.MaxValue);  // Tells you the min & max for byte
            Console.WriteLine("{0}{1}", float.MinValue, float.MaxValue);    // Tells you min & max for float
        }
    }
} 
