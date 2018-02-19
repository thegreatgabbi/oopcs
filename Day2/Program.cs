using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Product
    {
        // attributes
        string name;
        string id;
        int quantity;

        public Product (string n, string i)
        {
            name = n;
            id = i;
            Quantity = 1;
        }

        public Product(string n, string i, int q)
        {
            name = n;
            id = i;
            Quantity = q;
        }
        // properties
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    // validation
                    quantity = value;
                }
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        // methods
        public void Restock(int q)
        {
            Quantity = Quantity + q;
        }
        public string Show()
        {
            return String.Format("Product:{0},{1},{2}", Name, Id, Quantity);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product("Table", "P10001", 20);
            Product b = new Product("Table", "P10001");
            Console.WriteLine(a.Show());
            a.Restock(12);
            Console.WriteLine(a.Show());
        }
    }
}
