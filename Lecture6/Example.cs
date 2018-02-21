using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    class Customer : IComparable
    {
        string name;
        int creditLimit;
        public Customer(string name, int creditLimit) 
        {
            this.name = name;
            this.creditLimit = creditLimit;
        }
        public override string ToString()
        {
            return String.Format("[Customer:{0}, {1}]", name, creditLimit);
            
        }
        public int CompareTo(object obj)
        {
            Customer c = (Customer) obj;
            return this.creditLimit.CompareTo(c.creditLimit); // find another attribute that you can CompareTo
        }
    }
    class Example
    {
        static void Main()
        {
            int[] numbers = new int[] { 5, 2, 19, 8 };
            Customer[] customers = new Customer[]
            {
                new Customer("Tan Ah Kow", 10000),
                new Customer("Lim Ah Lian", 5000),
                new Customer("Goh Ah Seng", 5000),
            };
            Array.Sort(numbers);
            Array.Sort(customers); // error: At least one object must implement IComparable
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(customers[i]);
            }
        }
    }
}
