using System;
using System.Collections.Generic;
using System.Linq;
//using System.text;
using System.Threading.Tasks;

namespace returnStatements
{
    class returns
    {
        static void Main(string[]args)
        {
            int number = 5;
            Console.WriteLine(cubeNum(number));
        }

        static int cubeNum(int num)
        {
            int result = (num*num*num);
            return result;
        }
    }
}
