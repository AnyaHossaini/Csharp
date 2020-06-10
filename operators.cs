using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace operators 
{
    class operPrac 
    {
        static void Main(string[]args)
        {
            // Basic practice
            var a = 10;
            var b = 3;
            
            Console.WriteLine(a+b);
            Console.WriteLine((float)a/(float)b);

            var c = 1;
            var d = 2;

            Console.WriteLine(c !=d);   // This will give us true or false back
        }
    }
}
