using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
    // theory part of enum is IMO poorly explained
{
    public enum ShippingMethod // enum is used for multiple related constants
                               // instead of declaring multiple constants
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //const int RegularAirMail = 1;
            //const int RegisteredAirMail = 2;
            //const int Express = 3;

            var method = ShippingMethod.Express;
            Console.WriteLine(method);
        }
    }
    
}