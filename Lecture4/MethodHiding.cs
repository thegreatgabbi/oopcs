using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Parent1
    {
        public void Method1()
        {
            Console.WriteLine("Parent Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Parent Method 2");
        }
    }
    public class Child1: Parent1
    {
        public new void Method1()
        {
            Console.WriteLine("Child Method 1");
        }
        public void Method3()
        {
            Console.WriteLine("Child Method 3");
        }
    }
}
