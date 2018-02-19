using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs_lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.setAge(10);
            Console.WriteLine(p1.getAge());

            Person p2 = new Person();
            // set
            p2.Age = 34;
            // get
            Console.WriteLine(p2.Age);

            Coin c1;
            c1 = new Coin();
            Coin c2;
            c2 = new Coin();

            for (int i = 0; i < 10; i++)
            {
                c1.Flip();
                Console.WriteLine(c1.GetFace());
            }
        }
    }
}
