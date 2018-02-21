using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    public abstract class Parent
    {
        public abstract void PMethod1(); // override this

        public void PMethod2()
        {
            Console.WriteLine("ISS");
        }
    }
    public class Child : Parent
    {
        public override void PMethod1()
        {
            Console.WriteLine("Venkat");
        }
        public void CMethod1()
        {
            base.PMethod2();
        }
    }
    public class Test
    {
        static void Main()
        {
            Parent p = new Child();
            p.PMethod1();
            p.PMethod2();
        }
    }
}
