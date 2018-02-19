using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs_lecture1
{
    class Person
    {
        // attributes
        string name;
        int age;

        public Person()
        {
            age = 1;
            name = "";
        }
        public Person(string n)
        {
            age = 1;
            name = n;
        }
        public Person(string n, int a)
        {
            age = a;
            name = n;
        }

        // methods
        public int getAge()
        {
            return age;
        }

        public void setAge(int newValue)
        {
            if (newValue > 0)
            {
                age = newValue;
            } else
            {
                Console.WriteLine("Age cannot be negative");
            }
        }

        public int Age {
            get
            {
                return age/365;
            }
            set
            {
                int newValue = value * 365;
                if (newValue > 0 )
                {
                    age = newValue;
                } else
                {
                    Console.WriteLine("Age cannot be negative");
                }
            }
        }
    }
}
