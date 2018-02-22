using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class Slide24Example
    {
        static void Main()
        {
            int x, y = 0;

            try
            {
                Console.WriteLine("Enter try block.");
                x = 10 / y; // error
                Console.WriteLine(x);
                Console.WriteLine("Exit try block.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("First exception:");
                Console.WriteLine(e.GetType());
            }
            catch (Exception e)
            {
                Console.WriteLine("Second Exception:");
                Console.WriteLine(e.GetType());
            }
            Console.WriteLine("End of method.");
        }
    }
}
