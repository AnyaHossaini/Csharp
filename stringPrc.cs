using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strings
{
    class stringPrc
    {
        static void Main(string[]args)
        {
            var firstName = "Billy";
            var lastName = "bob";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("my name is {0}{1}", firstName, lastName);

            var names = new string[3]{"billy","bobby","brown"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook here";
            Console.WriteLine(text);

            var test = 
            @"pop
            pop
            pop";

            Console.WriteLine(test);
        }
    }
}
