using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail =2,
        Express =3
    }
    class enumPrc
    {
        static void Main(string[]args)
        {
            
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

           // var ShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            
        }
    }
}
