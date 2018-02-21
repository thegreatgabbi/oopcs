using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
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

        public int CompareTo(object obj)
        {
            Customer c = (Customer)obj;
            if ( this.balance < c.balance ) // -1 if the balance of the current customer is less than that of the parameter
            {
                return -1;
            }
            else if ( this.balance == c.balance ) // 0 if the balances are equal, and
            {
                return 0;
            }
            else // +1 if it is greater.
            {
                return +1;
            }
        }
    }

    public class MainClass
    {
        static void Main()
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street", 2000);
            Customer d = new Customer("Tan Ah Lian", "81 Berry Road", 1500);
            int n = 65;
            int m = 231;
            Console.WriteLine(n < m);
            Console.WriteLine(c < d);
        }
    }
}
