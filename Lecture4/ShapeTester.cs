using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class ShapeTester
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(4, 5);
            Console.WriteLine("Area of r:\t{0}", r.GetArea());
            Console.WriteLine("Perimeter of r:\t{0}", r.GetPerimeter());

            Parallelogram p = new Parallelogram(10, 15, 60);
            Console.WriteLine("p has angle:\t{0}", p.GetAngle());
            Console.WriteLine("Area of p:\t{0}", p.GetArea());
            Console.WriteLine("Perimeter of p:\t{0}", p.GetPerimeter());
        }
    }
}
