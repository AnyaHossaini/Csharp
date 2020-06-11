using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datesTimes
{
    class Datetimeprc
    {
        static void Main(string[]args)
        {
           var dateTime = new DateTime(2015, 1,1);
           var now = DateTime.Now; // Current date time
           var today = DateTime.Today; // Today's date

        //    Console.WriteLine("Hour: " + now.hour);
        //    Console.WriteLine("Minute: " + now.Minute);

           // Date time is immuntable

           var tomorrow = now.AddDays(1);
           var yesterdat = now.AddDays(-1);

           Console.WriteLine(now.ToLongDateString());
           Console.WriteLine(now.ToShortDateString());
           Console.WriteLine(now.ToLongTimeString());
           Console.WriteLine(now.ToShortTimeString());
           Console.WriteLine(now.ToString("yyyy-MM-dd"));
        }
    }
}
