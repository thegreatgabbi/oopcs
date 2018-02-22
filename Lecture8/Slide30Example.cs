using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    public enum Days2 {Mon, Tue, Wed, Thur, Fri, Sat, Sun};
    public struct Birthday
    {
        private Days2 day;
        private string month;

        public Days2 BDayOfWeek {
            get { return day; }
            set { day = value; }
        }

        public string BDayMonth
        {
            get { return month; }
            set { month = value; }
        }

    }

    class Slide30Test
    {
        static void Main()
        {
            Birthday myBirthday = new Birthday();
            Console.WriteLine(myBirthday.BDayMonth);
            Console.WriteLine(myBirthday.BDayOfWeek);
            myBirthday.BDayMonth = "December";
            myBirthday.BDayOfWeek = Days2.Mon;
            Console.WriteLine(myBirthday.BDayMonth);
            Console.WriteLine(myBirthday.BDayOfWeek);
        }
    }
}
