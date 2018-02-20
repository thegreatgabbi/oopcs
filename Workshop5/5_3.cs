using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    using System;

    namespace Testing
    {
        // - Where is the ToString() method defined?
        // In System.Int32 and System.Object.

        // - Is it defined for Int32 or Customer?
        // Int32 yes, Customer no.

        // - Add a ToString() method to the Customer class and see the difference in the output produced.
        // - You might do the same for your other classes -- the method StrFaceUp() for the Dice class in workshop 2.3 maybe replaced with ToString().
        class Customer
        {
            private string name;
            private string address;
            public string Name
            {
                get
                {
                    return name;
                }
            }
            public string Address
            {
                get
                {
                    return address;
                }
            }
            public Customer(string n, string a)
            {
                name = n;
                address = a;
            }
            public override string ToString()
            {
                return "hello";
            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                Customer c = new Customer("Tan Ah Kow", "4 Short Street");
                int n = 65;
                Console.WriteLine(n); // 65
                Console.WriteLine(c); // Workshop5.Testing.Customer
                Console.WriteLine(n.ToString()); // 65
                Console.WriteLine(); // Workshop5.Testing.Customer
            }
        }
    }
}
