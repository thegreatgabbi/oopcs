using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class DerivedClassConstructor
    {
        public static void Main()
        {
            Child3 c = new Child3("ISS");
        }
    }
    
    public class Parent3
    {
        public Parent3()
        {
            Console.WriteLine("Venkat");
        }
        public Parent3(string s)
        {
            Console.WriteLine(s);
        }
    }
    public class Child3 : Parent3
    {
        public Child3() : base()
        {
            Console.WriteLine("Ramanathan");
        }
        public Child3(string s) : base(s)
        {
            Console.WriteLine(s);
        }
    }
}
