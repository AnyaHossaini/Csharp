using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Stringbuilding 
{
    class strbuildPrc 
    {
        static void Main (string[] args) 
        {
            //Appending
            var builder = new StringBuilder();
            builder.Append('-',10);
            builder.AppendLine();
            builder.Append("Header");
             builder.AppendLine();
            builder.Append('-',10);
            Console.WriteLine(builder);
            builder.Replace('-','+');

            //remove
            builder.Remove(0,10);

            //insert
            builder.Insert(0, new string ('*',10));

            //indexer
            Console.Write("First char: " + builder[0]);
           
            Console.WriteLine(builder);
        }
    }
}
