using System;
using System.Collections.Generic;
using System.Linq;
//using System.text;
using System.Threading.Tasks;

namespace simpleContains
{
    class containing
    {
        static void Main(string[]args)
        {
            string phrase = "I walked my dog on my way to work today";
           // Console.WriteLine(phrase[0]);
           //Console.WriteLine(phrase.IndexOf("walked"));
           Console.WriteLine(phrase.Substring(16));
           Console.WriteLine(phrase.Substring(0,16));
        }
    }
}
