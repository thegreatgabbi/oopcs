using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class MonetaryCoin : Coin
    {
        int valu;
        string country;

        public MonetaryCoin(int v, string c): base(0)
        {
            valu = v;
            country = c;
        }
        public int GetValue()
        {
            return valu;
        }
        public string GetCountry()
        {
            return country;
        }
    }
}
