using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    // From Lecture 7 slide 19
    class ExceptionHandlingExample
    {
        static void Main()
        {
            int x, y = 0; // x is not assigned

            try
            {
                Console.WriteLine("Enter try block.");
                x = 10 / y; // error!
                Console.WriteLine(x);
                Console.WriteLine("Exit try block.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Enter catch block.");
                Console.WriteLine(e);
                Console.WriteLine("Exit catch block.");
            }
            Console.WriteLine("After try-catch block.");
        }
    }
}
