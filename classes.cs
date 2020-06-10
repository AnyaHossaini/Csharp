using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes 
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    class classPrc 
    {
        static void Main(string[]args)
        {
            var john = new Person();
            john.FirstName = "john";
            john.LastName = "smith";
            john.Introduce();

        }
    }
}
