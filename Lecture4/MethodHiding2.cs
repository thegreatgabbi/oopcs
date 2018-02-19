using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Parent2
    {
        public void MyMethod(int x)
        {
            Console.WriteLine("Parent: MyMethod");
        }
    }
    public class Child2: Parent2
    {
        public new void MyMethod(int a)
        {
            Console.WriteLine("Child: MyMethod");
        }
        public void Method3()
        {
            MyMethod(3); // calls Child2 MyMethod
            base.MyMethod(3); // calls Parent2 MyMethod
        }
    }
}
