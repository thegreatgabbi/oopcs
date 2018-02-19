using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class OrnamentCoinApp
    {
        public static void Main()
        {
            OrnamentCoin C1 = new OrnamentCoin("Floral", "Silver", false);
            OrnamentCoin C2 = new OrnamentCoin("GirlFriend", "Gold", true);

            Console.WriteLine(C1.GetDesign());
            Console.WriteLine(C2.GetMetal());
            Console.WriteLine(C2.GetHook());
            C2.RemoveHook();
            Console.WriteLine(C2.GetHook());
        }
    }
}
