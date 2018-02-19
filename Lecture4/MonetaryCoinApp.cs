using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class MonetaryCoinApp
    {
        public static void Main()
        {
            MonetaryCoin C1 = new MonetaryCoin(50, "Singapore");
            MonetaryCoin C2 = new MonetaryCoin(10, "Singapore");
            MonetaryCoin C3 = new MonetaryCoin(50, "US");

            Console.WriteLine(C2.GetCountry());
            Console.WriteLine(C2.GetValue());
            Console.WriteLine(C3.GetCountry());
            Console.WriteLine(C1.GetFace());
            Console.WriteLine(C2.GetFace());
            C2.Flip();
            Console.WriteLine(C2.GetFace());
        }
    }
}
