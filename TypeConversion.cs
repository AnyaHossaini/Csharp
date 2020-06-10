using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace typeConversion 
{
    class pracConversion 
    {
        static void Main(string[]args)
        {
            // Converting
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Casting 
            int a = 1000;
            byte c = (byte)a;
            Console.WriteLine(c);

            // Converting
            var number = "1234";
            int r = Convert.ToInt32(number);
            Console.WriteLine(r);

            //Try catch block

            try
            {
                var number1 = "1234";
                byte e = Convert.ToByte(number1);
                Console.WriteLine(e);
                
            }
            catch (System.Exception)
            {
                Console.WriteLine("Number can't be converted to byte");
            }
            try
            {
                string str = "true";
                bool q = Convert.ToBoolean(str);
                Console.WriteLine(q);
            }
            catch (System.Exception)
            {  
                Console.WriteLine("Cannot covert to bool");
            }
        }
    }
}
