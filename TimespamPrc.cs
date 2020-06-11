using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSpanCode
{
    class TimespamPrc
    {
        static void Main(string[]args)
        {
            //Creating
            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("add: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine("add: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString " + timeSpan.ToString());

            //Prase
            Console.WriteLine("Parse: " +TimeSpan.Parse("01:02:03"));
        }
    }
}
