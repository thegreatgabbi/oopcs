using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6_3
{
    class Customer : IComparable
    {
        private string name;
        private string address;
        private double balance;

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
        public string Balance
        {
            get
            {
                return Convert.ToString(balance);
            }
        }
        public Customer(string n, string a, double b)
        {
            name = n;
            address = a;
            balance = b;
        }
        // Overload '<' operator
        public static bool operator < (Customer a, Customer b)
        {
            return (a.balance < b.balance);
        }
        // Overload '>' operator
        public static bool operator > (Customer a, Customer b)
        {
            return (a.balance > b.balance);
        }

        // Implement CompareTo
        public int CompareTo(object obj)
        {
            Customer c = (Customer)obj;
            return this.balance.CompareTo(c.balance); // find another attribute that you can CompareTo
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("A", "4 Short Street", 2000);
            Customer d = new Customer("B", "81 Berry Road", 2000);
            int n = 65;
            int m = 231;
            Console.WriteLine(n < m);
            Console.WriteLine(c < d);

            // Test case for CompareTo
            Customer[] cArray = new Customer[] { c, d };

            foreach (Customer customer in cArray)
            {
                Console.WriteLine(customer.Name);
            }
            Array.Sort(cArray);
            Console.WriteLine("Sorted:");
            foreach (Customer customer in cArray)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
    // Q: Why should comparing integers be allowed, but not for objects of Customer?
    // A: Customer is a custom type which does not overload the '<' operator.

    // Q: What if we wanted to compare Customer objects according to their account balance?
    // A: We would have to overload the '<' and '>' operator. (See above)
}
