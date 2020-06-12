using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdecuralProgramming
{
    class ProdProgPrc
    {
        static void Main(string[]args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var reversed = reverseName(name);

            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string reverseName(string name)
        {
            var array = new char[name.Length];
            for(var i = name.Length; i > 0; i --)
            {
                array[name.Length - i] = name[i - 1];
            }

            var reversed = new string(array);
            return reversed;

        }
    }
}
