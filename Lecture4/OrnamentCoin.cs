using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class OrnamentCoin : Coin
    {
        string design;
        string metal;
        bool hook;
        public OrnamentCoin(string d, string m, bool h):base(0)
        {
            this.design = d; this.metal = m; this.hook = h;
        }
        public string GetDesign()
        {
            return design;
        }
        public string GetMetal()
        {
            return metal;
        }
        public bool GetHook()
        {
            return hook;
        }
        public void RemoveHook()
        {
            hook = false;
        }
    }
}
