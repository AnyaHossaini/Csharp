using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strings
{
    class StringPrc2
    {
        static void Main(string[]args)
        {
            var fullName = "Billy Bob ";

            //trim
            Console.WriteLine("Trim: '{0}'",fullName.Trim());   //Gets rid of white space at the END 
            Console.WriteLine("-----------------------------\n");

            //toUpper
            Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper()); //Trims it and converts it to upper    
            Console.WriteLine("-----------------------------\n");

            //index of
            var index = fullName.IndexOf(' ');  //Gets the index of the space
            var firstName = fullName.Substring(0, index);   // Takes the full name and cuts it from the start till the space
            var lastName = fullName.Substring(index +1);    // Takes the ful name and cuts it where the space is till the end 
            Console.WriteLine("FirstName: " + firstName);   // prints out the first half
            Console.WriteLine("LastName: " + lastName);     // prints out the second half
            Console.WriteLine("-----------------------------\n");

            //Spilt method
            var names = fullName.Split(' ');    // This splits at the space and puts everything in an Array
            Console.WriteLine("FirstName: " + names[0]);    //Everything before the space goes to the first index
            Console.WriteLine("LastName: " + names[1]); // Everything after the space goes to the second index
            Console.WriteLine("-----------------------------\n");

            //Replace
            Console.WriteLine(fullName.Replace("Billy", "john"));  //Replace with another string
            Console.WriteLine(fullName.Replace('y','Y'));  //Replaces the character
            Console.WriteLine(fullName.Replace(' ','-'));   // Replaces spce with -
            Console.WriteLine("-----------------------------\n");

            //NullOrEmpty
            if(String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");
            Console.WriteLine("-----------------------------\n");

            //Coverting string to int
            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);
            Console.WriteLine("-----------------------------\n");

            //Convert int to string
            float price = 29.95f;
            Console.Write(price.ToString("C"));
            Console.WriteLine("-----------------------------\n");


        }
    }
}
