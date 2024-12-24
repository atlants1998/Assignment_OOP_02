using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    public class HiringDate
    {
        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor with validation
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }


        // Override ToString for easy string representation
        public override string ToString()
        {
            return $"Day:{Day}\n Month:{Month}\n Year:{Year}";
        }

        // Method to convert to DateTime
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
    }
}
