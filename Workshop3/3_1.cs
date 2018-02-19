using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Workshop3
{
    class BankAccount
    {
        // attributes
        string accountNumber;
        string accountHolderName;
        double balance;

        // properties
        public string AccountNumber {
            get
            {
                return accountNumber;
            }
            set
            {
                if ( Regex.IsMatch(value, @"[0-9]{3}\-[0-9]{3}-[0-9]{3}") ) {
                    accountNumber = value;
                } else {
                    Console.WriteLine("Account number must be in the format \"XXX-XXX-XXX\".");
                }
            }
        }
        public string AccountHolderName {
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
                } else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }

        // constructor
        public BankAccount(string BankAccount, string name, double balance)
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
        public void TransferTo(double amount, BankAccount another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }
        public string Show()
        {
            return String.Format("{0} ({1}) has {2:C}", AccountHolderName, AccountNumber, Balance);
        }
    }
    class BankTest
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount("001-001-001", "Tan Ah Kow", 2000);
            BankAccount b = new BankAccount("001-001-002", "Kim Keng Lee", 5000);
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
