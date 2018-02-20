using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    public class Parent
    {
        private int _i; // if you want the property to be named 'i'
        protected int j = 3; // why is it protected instead of private?

        public int i
        {
            get { return _i; }
            set { _i = value; }
        }
        public virtual int Calculate()
        {
            return i + j;
        }

    }

    public class Child : Parent
    {
        public override int Calculate()
        {
            return i * i + j * j;
        }
    }
    public class Test
    {
        public static void Main()
        {
            Parent p = new Parent();
            p.i = 5;
            Console.WriteLine(p.Calculate());

            Child c = new Child();
            c.i = 5;
            Console.WriteLine(c.Calculate());

            Parent p2;
            p2 = c; // widening conversion
            Console.WriteLine(p2.Calculate());
        }
    }
}
