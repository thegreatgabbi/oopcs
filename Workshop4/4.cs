using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Workshop4
{
    public class Customer
    {
        // attributes
        string name;
        string address;
        string passportNumber;
        DateTime dateOfBirth;

        // properties
        public Customer(string name, string address, string passportNumber, DateTime dateOfBirth) :
            this(name, address, passportNumber)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public Customer(string name, string address, string passportNumber, int age) :
            this(name, address, passportNumber)
        {
            // convert age to date of birth
            this.dateOfBirth = new DateTime(DateTime.Now.Year - age, 1, 1);
        }
        private Customer(string name, string address, string passportNumber)
        {
            this.name = name;
            this.address = address;
            this.passportNumber = passportNumber;
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

    public class BankAccount3
    {
        // attributes
        private string accountNumber;
        private Customer accountHolderName;
        private double balance;
        private double interestRate;

        // properties
        public string AccountNumber
        {
            get { return accountNumber; }
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
        public Customer AccountHolderName { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public BankAccount3(string accountNumber, Customer accountHolderName, 
            double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }
        public BankAccount3(string accountNumber, Customer accountHolderName,
            double balance, double interestRate) : this(accountNumber, accountHolderName, balance)
        {
            this.interestRate = interestRate;
        }

        // methods
        public void Withdraw(double amount)
        {
            if ( amount > balance ) {
                Console.WriteLine("Amount cannot be less than balance.");
            } else
            {
                balance -= amount;
            }
            
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void TransferTo(double amount, BankAccount3 another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }
        public double CalculateInterest()
        {
            double interest = balance * ( interestRate / 100 );
            return interest;
        }
        public void CreditInterest()
        {
            balance += CalculateInterest();
        }
        public string Show()
        {
            return String.Format("{0} ({1}) has {2:C}", 
                AccountHolderName, AccountNumber, Balance);
        }
    }
    public class SavingsAccount : BankAccount3
    {
        public SavingsAccount(string number, Customer name, double balance) : 
            base(number, name, balance, 1)
        {
            if (balance < 0)
            {
                this.InterestRate = 0;
            }
        }
    }
    public class CurrentAccount : BankAccount3
    {
        public CurrentAccount(string number, Customer name, double balance) : 
            base(number, name, balance, 0.25)
        {
            if (balance < 0)
            {
                this.InterestRate = 0;
            }
        }
    }
    public class OverdraftAccount : BankAccount3
    {
        public OverdraftAccount(string number, Customer name, double balance): 
            base(number, name, balance, 0.25)
        {
            if (balance < 0)
            {
                this.InterestRate = -6;
            }
        }
    }
    public class App
    {
        public static void Main()
        {
            Customer cus1 = new Customer("Tan Ah Kow", "2 Rich Street",
                                      "P123123", 20);
            Customer cus2 = new Customer("Kim May Mee", "89 Gold Road",
                                      "P334412", 60);

            BankAccount3 a1 = new BankAccount3("S0000223", cus1, 2000);
            Console.WriteLine(a1.CalculateInterest());
            OverdraftAccount a2 = new OverdraftAccount("O1230124", cus1, 2000);
            Console.WriteLine(a2.CalculateInterest());
            CurrentAccount a3 = new CurrentAccount("C1230125", cus2, 2000);
            Console.WriteLine(a3.CalculateInterest());
        }
    }
}
