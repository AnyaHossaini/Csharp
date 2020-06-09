using System;
using System.Collections.Generic;
using System.Linq;
//using System.text;
using System.Threading.Tasks;

namespace learnMethods
{
    class Method
    {
        static void Main(string[]args)
        {
            
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What is your age: ");
            string age = Console.ReadLine();

            sayHi(name,age);
        }
        static void sayHi(string name, string age)
        {
            Console.WriteLine("hello " + name + " you are " + age);
        }
    }
}
