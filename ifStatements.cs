using System;
using System.Collections.Generic;
using System.Linq;
//using System.text;
using System.Threading.Tasks;

namespace ifStatements
{
    class ifPractice
    {
        static void Main(string[]args)
        { 
            Console.WriteLine(GetMax(10,20));
        }
        static int GetMax(int num1,int num2)
        {
            int result;
            if( num1 > num2)
            {
                Console.WriteLine("The first number is larger than the second");
                result = num1;
            }
            else if(num1 == num2)
            {
                Console.WriteLine("The numbers are equal to each other");
                result = 0; 
            }
            else
            {
                Console.WriteLine("The second number is larger than the first");
                result = num2;
            }
            return result;
        }
    }
}
