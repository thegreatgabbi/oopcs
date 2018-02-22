using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    enum Days { Mon, Tue, Wed, Thur, Fri };
    public struct MyStruct
    {
        
    }
    class MyStructTest
    {
        static void Main()
        {
            Days currentDay;

            currentDay = Days.Fri;
            Console.WriteLine(Days.Fri);
            currentDay++;
            Console.WriteLine(currentDay);

        }
    }
}
