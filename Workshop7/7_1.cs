using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7
{
    // a. Consider the earlier workshop 2.1 on the Triangle class and identify possible error scenarios -- for example, the sides might not represent a valid triangle.
    // The side might be a negative number or one side could be longer than the other 2 combined

    // 

    

    class InvalidSideException : ApplicationException
    {
        public InvalidSideException() : base()
        {

        }
        public InvalidSideException(string message) : base(message)
        {

        }
        public InvalidSideException(string message, Exception innerExc) : base(message, innerExc)
        {

        }
    }

    class NegativeSideException : ApplicationException
    {
        public NegativeSideException() : base()
        {

        }
        public NegativeSideException(string message) : base(message)
        {

        }
        public NegativeSideException(string message, Exception innerExc) : base(message, innerExc)
        {

        }
    }

    class Triangle
    {
        double s1, s2, s3;
        public Triangle(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0)) {
                throw new NegativeSideException();
            } else if ((a > b + c) || (b > a + c) || (c > a + b))
            {
                throw new InvalidSideException();
            } else
            {
                s1 = a;
                s2 = b;
                s3 = c;
            }
        }

        public double Side1
        {
            get
            {
                return (s1);
            }
        }

        public double Side2
        {
            get
            {
                return (s2);
            }
        }

        public double Side3
        {
            get
            {
                return (s3);
            }
        }

        public double Area
        {
            get
            {
                double s = (s1 + s2 + s3) / 2;
                double r = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
                return (r);
            }
        }

        public double Perimeter
        {
            get
            {
                return (s1 + s2 + s3);
            }
        }

        public bool IsRightAngle
        {
            get
            {
                return ((s1 * s1 + s2 * s2) == (s3 * s3));
            }
        }

        public string StrValue()
        {
            return (String.Format("Triangle: {0},{1},{2}", Side1, Side2, Side3));
        }
    }
    class TriangleTest
    {
        public static void Main()
        {
            Triangle t = new Triangle(10, 24, 26);
            Console.WriteLine(t.StrValue());
            Console.WriteLine(t.Perimeter);
            Console.WriteLine(t.Area);
            Console.WriteLine(t.IsRightAngle);

            Triangle t2;
            try
            {
                t2 = new Triangle(10, 24, -40);
                Console.WriteLine(t2.StrValue());
                Console.WriteLine(t2.Perimeter);
                Console.WriteLine(t2.Area);
                Console.WriteLine(t2.IsRightAngle);
            }
            catch (InvalidSideException e)
            {
                Console.WriteLine(e);
            }
            catch (NegativeSideException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}