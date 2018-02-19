using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class HideApp
    {
        public static void Main()
        {
            Parent1 p = new Parent1();
            p.Method1();
            p.Method2();

            Child1 c = new Child1();
            c.Method1();
            c.Method2();
            c.Method3();
        }
    }
}
