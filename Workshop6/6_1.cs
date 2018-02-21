using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    // a. What common attributes or methods might be more appropriately refactored into a base class?
    // Area(), Perimeter()

    // b. What methods in the base class might be more appropriately annotated as abstract?
    // Area(), Perimeter()

    // c. Enhance your geometric shape classes Triangle and Rectangle using an abstract base class.

    public class Triangle : Shape
    {
        int side1;
        int side2;
        int side3;

        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override float Area()
        {
            float p = this.Perimeter() /2;
            double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return (float) area;
        }
        public override float Perimeter()
        {
            double perimeter = side1 + side2 + side3;
            return (float) perimeter;
        }
    }
    public class Rectangle : Shape
    {
        int length;
        int breadth;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override float Area()
        {
            return length * breadth;
        }

        public override float Perimeter()
        {
            return 2 * (length + breadth);
        }
    }
    public abstract class Shape
    {
        public abstract float Area();
        public abstract float Perimeter();
    }

    // d. What difference does a Shape base class make?
    // A Shape base class will contain methods (e.g. Area(), Perimeter() that can be inherited by child classes

    // e. What difference does a Shape abstract base class make?
    // A Shape abstract base class forces its child classes to implement Shape's abstract methods

    public class Test1
    {
        static void Main()
        {
            Rectangle r = new Rectangle(4, 5);
            Triangle t = new Triangle(3, 4, 5);
            
        }
    }
}
