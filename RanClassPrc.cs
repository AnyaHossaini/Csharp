using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomClasses
{
    class RanClassPrc
    {
        static void Main(string[]args)
        {
            const int Legnth = 10;
            var random = new Random();

            for(var i = 0; i < Legnth; i++)
                Console.WriteLine(random.Next());
            
            Console.WriteLine("---------------------------");

            for(var i = 0; i < Legnth; i ++)
                Console.WriteLine(random.Next(1,Legnth));
            
            Console.WriteLine("---------------------------");
            Console.WriteLine((int)'a');

            Console.WriteLine("---------------------------");

            char[] buffer = new char[Legnth];

            for(var i = 0; i < Legnth; i ++)
                buffer[i]=((char)('a' + random.Next(0,26)));
            
            var password = new string(buffer);
            Console.WriteLine(password);
            Console.WriteLine("---------------------------");
            
        }
    }
}
