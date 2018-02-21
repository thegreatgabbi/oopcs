using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Triangle
    {
        // attributes
        float side1;
        float side2;
        float side3;

        // properties
        public float Side1 {
            get {
                return side1;
            }
        }
        public float Side2
        {
            get
            {
                return side2;
            }
        }
        public float Side3
        {
            get
            {
                return side3;
            }
        }

        public Triangle(float side1, float side2, float side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // methods
        public double Area()
        {
            double p = Perimeter() / 2;
            double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return area;
        }
        public double Perimeter()
        {
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }
    }
    class Rectangle
    {
        private float length;
        private float breadth;

        public float Length {
            get {
                return length;
            }
        }
        public float Breadth {
            get {
                return breadth;
            }
        }
        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public double Area()
        {
            return length * breadth;
        }
        public double Perimeter()
        {
            return 2 * (length + breadth);
        }
    }
    class Program
    {
        static void Main()
        {
            Triangle t = new Triangle(4, 5, 6);
            Console.WriteLine("The area of the triangle is {0}", t.Area());
            Console.WriteLine("The perimeter of the triangle is {0}", t.Perimeter());

            Rectangle r = new Rectangle(8, 10);
            Console.WriteLine("The area of the rectangle is {0}", r.Area());
            Console.WriteLine("The perimeter of the rectangle is {0}", r.Perimeter());
        }
    }
}
