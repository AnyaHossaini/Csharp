using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forEachcode
{
    class FEprc
    {
        static void Main(string[]args)
        {
            var name = "Billy bobby brown";
            
            foreach (var characters in name)
            {
                Console.WriteLine(characters);
                
            }
        }
    }
}
