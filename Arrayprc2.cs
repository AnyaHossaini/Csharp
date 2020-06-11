using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Arrayprc
    {
        static void Main(string[]args)
        {
            var numbers = new[] {3,7,9,2,14,6};

            //length
            Console.WriteLine("length: " + numbers.Length);
            Console.WriteLine("---------------------------");

            // IndexOf()
            var index = Array.IndexOf(numbers,9);
            Console.WriteLine("Index of 9: " + index);
            Console.WriteLine("---------------------------");

            // Clear()
            Array.Clear(numbers,0,2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);   
            }
            Console.WriteLine("---------------------------");

            // Copy()
            int [] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(var n in another)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------------------------");

            //Sort()
            Array.Sort(numbers);
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------------------------");

            //Reverse
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);    
            }
            Console.WriteLine("---------------------------");


        }
    }
}
