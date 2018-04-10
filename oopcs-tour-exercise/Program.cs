using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelAgency t = new TravelAgency("Tan Ah Huat Travel Far");
            t.Add(new Customer("Tan Lian Hwee", "Clementi Road", "C10010")); t.Add(new Customer("Lim Teck Gee", "Kent Ridge Road", "C10020")); t.Add(new Customer("Koh Ghim Moh", "Dover Road", "C10030")); t.Add(new Customer("Liat Kim Ho", "West Coast Road", "C10040"));
            t.Add(new Tour("Paris", 3400, 3));
            t.Add(new Tour("London", 3200, 3));
            t.Add(new Tour("Munich", 3100, 2));
            t.Add(new Tour("Milan", 3500, 3));
            TourPackage p = new TourPackage("Europe");
            p.ConsistOf(t.FindTour("London"));
            p.ConsistOf(t.FindTour("Paris"));
            t.Add(p);
            t.Add(new Trip(t.FindTour("Paris"), new DateTime(2015, 4, 2), 20));
            t.Add(new Trip(t.FindTour("Munich"), new DateTime(2015, 4, 8), 15));
            t.Add(new Trip(t.FindTour("Europe"), new DateTime(2015, 4, 12), 17));
            t.MakeBooking(t.FindCustomer("Lim Teck Gee"), t.FindTrip("Paris"), 7);
            t.MakeBooking(t.FindCustomer("Liat Kim Ho"), t.FindTrip("Europe"), 2);
            t.MakeBooking(t.FindCustomer("Koh Ghim Moh"), t.FindTrip("Munich"), 1);
            t.MakeBooking(t.FindCustomer("Tan Lian Hwee"), t.FindTrip("Europe"), 3);
            t.ListTours();
            t.ListTrips();
        }
    }
    class Customer
    {
        string name;
        string address;
        string id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Id
        {
            get
            {
                return name;
            }
        }

        public Customer(string name, string address, string id)
        {
            this.name = name;
            this.address = address;
            this.id = id;
        }
    }
    class TourGuide
    {
        string name;
        string address;
        int salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public TourGuide(string name, string address, int salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }
    }
    class Tour
    {
        string name;
        int cost;
        int duration;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public virtual int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Tour(string name, int cost, int duration)
        {
            this.name = name;
            this.cost = cost;
            this.duration = duration;
        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}", name, cost, duration);
        }
    }
    class TourPackage : Tour
    {
        List<Tour> listOfTours;
        public override int Cost
        {
            get
            {
                int totalCost = 0;
                foreach (Tour l in listOfTours)
                {
                    totalCost += l.Cost;
                }
                return (int)(0.9 * totalCost);
            }
        }
        public override int Duration
        {
            get
            {
                int totalDuration = 0;
                foreach (Tour l in listOfTours)
                {
                    totalDuration += l.Duration;
                }
                return totalDuration;
            }
        }

        public TourPackage(string tour) : base(tour, 0, 0)
        {
            this.listOfTours = new List<Tour>();
        }
        public void ConsistOf(Tour t)
        {
            listOfTours.Add(t);
        }

    }
    class Trip
    {
        Tour tour;
        DateTime when;
        int maximum;
        List<Booking> currentBookings;

        public Tour Tour
        {
            get { return tour; }
            set { tour = value; }
        }
        public DateTime When
        {
            get { return when; }
            set { when = value; }
        }
        public int Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }
        public List<Booking> CurrentBookings
        {
            get { return currentBookings; }
            set { currentBookings = value; }
        }

        public Trip (Tour tour, DateTime when, int maximum)
        {
            this.tour = tour;
            this.when = when;
            this.maximum = maximum;
            this.currentBookings = new List<Booking>();
        }
        public void Book (Customer customer, int N)
        {
            Booking b = new Booking(customer, this, N);
            if (N > maximum)
            {
                throw new ApplicationException();
            }
            currentBookings.Add(b);
        }
        public int GetRevenue()
        {
            int totalRevenue = 0;
            foreach (Booking b in currentBookings)
            {
                totalRevenue += b.TotalCost;
            }
            return totalRevenue;
        }

    }
    class Booking
    {
        Customer customer;
        Trip trip;
        int number;
        int totalCost;

        public int TotalCost
        {
            get
            {
                return totalCost;
            }
            set
            {
                if (number > 5)
                {
                    totalCost = (int)(0.95 * value);
                }
                
            }
        }

        public Booking(Customer customer, Trip trip, int number)
        {
            this.customer = customer;
            this.trip = trip;
            this.number = number;
        }
        
    }
    class TravelAgency
    {
        string name;
        List<Customer> customerList;
        List<Tour> tourList;
        List<Trip> tripList;

        public TravelAgency(string name)
        {
            this.name = name;
            customerList = new List<Customer>();
            tourList = new List<Tour>();
            tripList = new List<Trip>();
        }
        public void Add(Customer customer)
        {
            customerList.Add(customer);
        }
        public void Add(Tour tour)
        {
            tourList.Add(tour);
        }
        public void Add(Trip trip)
        {
            tripList.Add(trip);
        }
        public Tour FindTour(string city)
        {
            return tourList.Find(x => x.Name == city);
        }
        public Trip FindTrip(string city)
        {
            return tripList.Find(x => x.Tour.Name == city);
        }
        public Customer FindCustomer(string name)
        {
            return customerList.Find(x => x.Name == name);
        }
        public void MakeBooking(Customer customer, Trip trip, int number)
        {
            trip.Book(customer, number);
        }
        public void ListTours()
        {
            foreach (Tour t in tourList)
            {
                Console.WriteLine("{0}: {1:C}, {2} days.", t.Name, t.Cost, t.Duration);
            }
        }
        public void ListTrips()
        {
            foreach (Trip t in tripList)
            {
                Console.WriteLine("{0} on {1}, Max pax: {2}", t.Tour.Name, t.When.ToShortDateString(), t.Maximum);
            }
        }
    }
}
