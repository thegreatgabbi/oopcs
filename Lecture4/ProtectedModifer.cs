using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Parent
    {
        private int x = 1;
        protected int X
        {
            get { return x; }
            set { x = value; }
        }
    }
    public class Child: Parent
    {
        public void ShowX()
        {
            Console.WriteLine("x is {0}", X);
        }
    }
}
