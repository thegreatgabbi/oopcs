using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Workshop7
{
    class NegativeBalanceException : ApplicationException
    {
        public NegativeBalanceException() : base()
        {
        }
        public NegativeBalanceException(string message) : base(message)
        {
        }
        public NegativeBalanceException(string message, Exception innerExc) : base(message, innerExc)
        {
        }
    }
    public class Account
    {
        // Attributes
        private string accountNumber;
        private Customer accountHolder;
        protected double balance;

        // Constructor
        public Account(string number, Customer holder, double bal)
        {
            accountNumber = number;
            accountHolder = holder;
            balance = bal;
        }

        public Account()
            : this("000-000-000", new Customer(), 0)
        {
        }

        // Properties
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public Customer AccountHolder
        {
            get
            {
                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            protected set
            {
                balance = value;
            }
        }

        // Methods

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        /// <summary>
        /// Withdraws amount from account.
        /// </summary>
        /// <exception cref="NegativeBalanceException">Yay for exception</exception>
        public virtual void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                balance = balance - amount;
            }
            else
            {
                throw new NegativeBalanceException("Account to be withdrawn cannot exceed balance");
            }
        }
        public void TransferTo(double amount, Account another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }

        public virtual double CalculateInterest()
        {
            return (Balance * 1 / 100);
        }

        public void CreditInterest()
        {
            Deposit(CalculateInterest());
        }

        public virtual string Show()
        {
            string m = String.Format
                         ("[BankAccount:accountNumber={0},accountHolder={1},balance={2}]",
                          AccountNumber, AccountHolder.Show(), Balance);
            return (m);
        }
    }

    public class CurrentAccount : Account
    {

        public CurrentAccount(string number, Customer holder, double bal)
            : base(number, holder, bal)
        {
        }
        public override double CalculateInterest()
        {
            return (Balance * 0.25 / 100);
        }
        public override string Show()
        {
            string m = String.Format
                         ("[CurrentAccount:accountNumber={0},accountHolder={1},balance={2}]",
                          AccountNumber, AccountHolder.Show(), Balance);
            return (m);
        }
    }

    public class SavingsAccount : Account
    {

        public SavingsAccount(string number, Customer holder, double bal)
            : base(number, holder, bal)
        {
        }

        public override double CalculateInterest()
        {
            return (Balance * 1 / 100);
        }

        public override string Show()
        {
            string m = String.Format
                         ("[SavingsAccount:accountNumber={0},accountHolder={1},balance={2}]",
                          AccountNumber, AccountHolder.Show(), Balance);
            return (m);
        }
    }

    public class OverdraftAccount : Account
    {
        private static double interestRate = 0.25;
        private static double overdraftInterest = 6;

        public OverdraftAccount(string number, Customer holder, double bal)
            : base(number, holder, bal)
        {
        }

        public override void Withdraw(double amount)
        {
                balance = balance - amount;
        }

        public override double CalculateInterest()
        {
            return ((Balance > 0) ?
                    (Balance * interestRate / 100) :
                    (Balance * overdraftInterest / 100));
        }

        public override string Show()
        {
            string m = String.Format
                         ("[OverdraftAccount:accountNumber={0},accountHolder={1},balance={2}]",
                          AccountNumber, AccountHolder.Show(), Balance);
            return (m);
        }

    }

    public class Customer
    {
        //
        // Attributes
        //

        private string name;
        private string address;
        private string passport;
        private DateTime dateOfBirth;

        //
        // Constructor
        //

        public Customer(string name, string address, string passport, DateTime dob)
            : this(name, address, passport)
        {
            this.dateOfBirth = dob;
        }

        public Customer(string name, string address, string passport, int age)
            : this(name, address, passport)
        {
            this.dateOfBirth = new DateTime(DateTime.Now.Year - age, 1, 1);
        }

        public Customer(string name, string address, string passport)
        {
            this.name = name;
            this.address = address;
            this.passport = passport;
        }

        public Customer()
            : this("ThisName", "ThisAddress", "ThisPassport", new DateTime(1980, 1, 1))
        {
        }

        //
        // Properties
        //

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
            set
            {
                address = value;
            }
        }

        public string Passport
        {
            get
            {
                return passport;
            }
            set
            {
                passport = value;
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - dateOfBirth.Year;
            }
        }

        // Methods

        public string Show()
        {
            string m = String.Format
                 ("[Customer:name={0},address={1},passport={2},age={3}]",
                          Name, Address, Passport, Age);
            return (m);
        }

    }

    public class BankBranch
    {
        private string branchName;
        private string branchManager;
        private List<Account> bankAccounts = new List<Account>();

        // Constructors
        public BankBranch(string branchName, string branchManager)
        {
            this.branchName = branchName;
            this.branchManager = branchManager;
        }
        public BankBranch(string branchName, string branchManager, List<Account> bankAccounts) : this(branchName, branchManager)
        {
            this.bankAccounts = bankAccounts;
        }

        // Properties
        public string BranchName
        {
            get
            {
                return branchName;
            }
            set
            {
                branchName = value;
            }
        }
        public string BranchManager
        {
            get
            {
                return branchManager;
            }
            set
            {
                branchManager = value;
            }
        }
        public List<Account> BankAccounts
        {
            get
            {
                return bankAccounts;
            }
            set
            {
                bankAccounts = value;
            }
        }

        

        // Methods
        public void AddAccount(Account a)
        {
            bankAccounts.Add(a);
        }
        public void PrintCustomers()
        {
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                Console.Write("{0}, ", bankAccounts[i].AccountHolder.Name);
            }
            Console.WriteLine();
        }
        public double TotalDeposits()
        {
            double totalDeposits = 0;
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                if (bankAccounts[i].Balance > 0)
                {
                    totalDeposits += bankAccounts[i].Balance;
                }
            }
            return totalDeposits;
        }
        public double TotalInterestPaid()
        {
            double total = 0;
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                if (bankAccounts[i].CalculateInterest() > 0)
                {
                    total += bankAccounts[i].CalculateInterest();
                }
            }
            return total;
        }
        public double TotalInterestEarned()
        {
            double total = 0;
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                if (bankAccounts[i].CalculateInterest() < 0)
                {
                    total -= bankAccounts[i].CalculateInterest();
                }
            }
            return total;
        }
    }

    public class BankTest
    {

        public static void Main()
        {
            Customer cus1 = new Customer("Tan Ah Kow", "2 Rich Street",
                                      "P123123", 20);
            SavingsAccount a1 = new SavingsAccount("S0000223", cus1, 2000);

            Customer cus2 = new Customer("Kim May Mee", "89 Gold Road",
                                      "P334412", 60);
            CurrentAccount a2 = new CurrentAccount("O1230124", cus2, 2000);

            Customer cus3 = new Customer("Jeremy Tan", "89 Tanjong Pagar",
                                      "P126838", 30);
            OverdraftAccount a3 = new OverdraftAccount("C1230125", cus3, 1000);

            try
            {
                a1.Withdraw(3000);
            } catch (NegativeBalanceException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                a2.Withdraw(3000);
            }
            catch (NegativeBalanceException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                a3.Withdraw(2000);
            }
            catch (NegativeBalanceException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}