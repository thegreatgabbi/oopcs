using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    // Define an IInvestment interface
    public interface IInvestment
    {
        double GetCost();
        double GetEstimatedValue();
        double GetProfits();
        DateTime GetDateAcquired();
    }
    public class Gold : IInvestment
    {
        public double GetCost()
        {
            return 40.0;
        }

        public DateTime GetDateAcquired()
        {
            return new DateTime(1400, 10, 10);
        }

        public double GetEstimatedValue()
        {
            return 200.0;
        }

        public double GetProfits()
        {
            double value = GetEstimatedValue();
            double cost = GetCost();
            return value - cost;
        }
    }
    public class Antique : IInvestment
    {
        public double GetCost()
        {
            return 30.0;
        }

        public DateTime GetDateAcquired()
        {
            return new DateTime(1800, 2, 4);
        }

        public double GetEstimatedValue()
        {
            return 2000.0;
        }

        public double GetProfits()
        {
            double value = GetEstimatedValue();
            double cost = GetCost();
            return value - cost;
        }
    }
    public class Coin : IInvestment
    {
        public double GetCost()
        {
            return 10.0;
        }

        public DateTime GetDateAcquired()
        {
            return new DateTime(2000, 12, 24);
        }

        public double GetEstimatedValue()
        {
            return 20.0;
        }

        public double GetProfits()
        {
            double value = GetEstimatedValue();
            double cost = GetCost();
            return value - cost;
        }
    }
    public class Investments
    {
        List<IInvestment> investments;

        public Investments(List<IInvestment> list)
        {
            investments = list;
        }

        public void ListInvestments()
        {
            foreach (IInvestment investment in investments)
            {
                Console.WriteLine("{0} was acquired {1:D}", investment.GetType(),  investment.GetDateAcquired());
            }
        }
        public double ComputeTotalValue()
        {
            double total = 0;
            foreach (IInvestment investment in investments)
            {
                total += investment.GetEstimatedValue();
            }
            return total;
        }
        public double ComputeTotalProfits()
        {
            double total = 0;
            foreach (IInvestment investment in investments)
            {
                total += investment.GetProfits();
            }
            return total;

        }
    }
    public class Test2
    {
        static void Main()
        {
            Coin c = new Coin();
            Gold g = new Gold();
            Antique a = new Antique();

            List<IInvestment> list = new List<IInvestment>
            {
                c,
                g,
                a
            };

            Investments i = new Investments(list);
            i.ListInvestments();
            Console.WriteLine("Total Value: {0}", i.ComputeTotalValue());
            Console.WriteLine("Total Profits: {0}", i.ComputeTotalProfits());
        }
    }
}
