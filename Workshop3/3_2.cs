using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Workshop3
{
    public class Customer
    {
        // attributes
        string name;
        string address;
        string passportNumber;
        DateTime dateOfBirth;

        // properties
        public Customer(string name, string address, string passportNumber, DateTime dateOfBirth)
        {
            this.name = name;
            this.address = address;
            this.passportNumber = passportNumber;
            this.dateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            // returns Customer's age
            // current datetime - date of birth
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            return age;
        }
        // other support methods
    }
    public class BankAccount2
    {
        // attributes
        string accountNumber;
        Customer accountHolderName;
        double balance;

        // properties
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{3}\-[0-9]{3}-[0-9]{3}"))
                {
                    accountNumber = value;
                }
                else
                {
                    Console.WriteLine("Account number must be in the format \"XXX-XXX-XXX\".");
                }
            }
        }
        public Customer AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }

        // constructor
        public BankAccount2(string BankAccount, Customer name, double balance)
        {
            AccountNumber = BankAccount;
            AccountHolderName = name;
            Balance = balance;
        }

        // methods
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void TransferTo(double amount, BankAccount2 another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }
        public string Show()
        {
            return String.Format("{0} ({1}) has {2:C}", AccountHolderName, AccountNumber, Balance);
        }
    }
    public class BankTest2
    {
        static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            BankAccount2 a = new BankAccount2("001-001-001", y, 2000);
            BankAccount2 b = new BankAccount2("001-001-002", z, 5000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
        }
    }

}
