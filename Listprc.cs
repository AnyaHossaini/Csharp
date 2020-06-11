using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListPractice
{
    class Listprc
    {
        static void Main(string[]args)
        {
            // Lists you can add as many objects as you like
            var numbers = new List<int>(){1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});
            foreach (var  number in numbers)
            {
                Console.WriteLine(number);
            }

            // index of
            Console.WriteLine("Index of 1: " +numbers.IndexOf(1));
            Console.WriteLine("last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("count: " + numbers.Count);

            for( var i = 0; i < numbers.Count; i ++)
            {
                 if(numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            //Clear method
            numbers.Clear();
            Console.WriteLine("count: " + numbers.Count);
        }
    }
}
