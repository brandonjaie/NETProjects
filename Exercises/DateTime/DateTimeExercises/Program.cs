using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DATETIME NULLABLE*/
            GetNullableDate();

            /* DATETIME PARAMETERIZED CONSTRUCTORS */
            GetParamedDateTimeConstructors();

            /* PARSE DATETIME */
            ParseDate();

            /* GET CURRENT DATE */
            GetCurrentDate();

            /* GET PART OF A DATE DATE */
            GetPartofDate();

            /* GET DAY OF WEEK */
            GetDayOfWeek();

            /* GET DAY OF YEAR */
            GetDayOfYear();

            /* Adding or Subtracting Dates With Timespan */

            AddTimeSpan();
            SubTimeSpan();

            /* Adding Via Date Parts */

            AddSubViaDateParts();

            Console.ReadKey();
        }

        private static void GetNullableDate()
        {
            // The default value for DateTime object is 1/1/0001 12:00:00 AM
            // when working with dates and times that may be unknown, you will have to mark the variable declaration as nullable
            DateTime? nullableDate = null;
            Console.WriteLine(nullableDate);
        }

        private static void GetParamedDateTimeConstructors()
        {
            // October 4th, 2019, 12:00:00 AM
            DateTime dateParamConstructor = new DateTime(2019, 10, 4);
            Console.WriteLine(dateParamConstructor);

            //Octover 4th, 2019 10:15:45 AM
            DateTime dateTimeParamConstructor = new DateTime(2019, 10, 4, 10, 15, 45);
            Console.WriteLine(dateTimeParamConstructor);
        }

        private static void ParseDate()
        {

            DateTime date;

            while (true)
            {
                Console.Write("\nEnter a date: ");
                string input = Console.ReadLine();

                if (DateTime.TryParse(input, out date))
                {
                    Console.WriteLine($"\n{date} is a valid date");
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{input} cannot be parsed");
                }
            }
        }

        private static void GetCurrentDate()
        {
            //Current date with time to the millisecond
            Console.WriteLine(DateTime.Now);

            //Current date with time 12:00:00 AM
            Console.WriteLine(DateTime.Today);

            //Current date with time to the millisecond UTC
            Console.WriteLine(DateTime.UtcNow);
        }

        private static void GetPartofDate()
        {
            DateTime d1 = DateTime.Parse("10/04/2019 1:30:00 PM");

            Console.WriteLine(d1.Year);    // 2019
            Console.WriteLine(d1.Month);   // 10
            Console.WriteLine(d1.Day);     // 4
            Console.WriteLine(d1.Hour);    // 1
            Console.WriteLine(d1.Minute);  // 30
            Console.WriteLine(d1.Second);  // 0
        }

        private static void GetDayOfWeek()
        {
            DateTime d1 = DateTime.Parse("01/08/2019 1:30:00 PM");

            DayOfWeek day = d1.DayOfWeek;

            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Its the weekend!");
                    break;
                default:
                    Console.WriteLine("Its a weekday.");
                    break;
            }
        }

        private static void GetDayOfYear()
        {
            DateTime d1 = DateTime.Parse("01/08/19 1:30:00 PM");

            // 01/08/19 1:30:00 PM is 277 days into the calendar year
            Console.WriteLine($"{d1} is {d1.DayOfYear} days into the calendar year");
        }

        private static void AddTimeSpan()
        {
            DateTime freeTrialStart = DateTime.Today;

            // 30 days, 0 hours, 0 minutes, 0 seconds
            TimeSpan daysToExpiry = new TimeSpan(30, 0, 0, 0);

            DateTime freeTrialEnded = freeTrialStart + daysToExpiry;
        }

        private static void SubTimeSpan()
        {
            if (DateTime.Today.Month == 1 && DateTime.Today.Day == 1)
            {
                Console.WriteLine("Happy New Year!");
            }
            else
            {
                DateTime nextNewYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
                TimeSpan daysUntilNewYears = nextNewYear - DateTime.Today;
                Console.WriteLine("There are {0} days until New Years",
                    daysUntilNewYears.Days);
            }
        }


        private static void AddSubViaDateParts()
        {
            DateTime date = DateTime.Today;

            // 1 year later
            date = date.AddYears(1);
            // 2 months later
            date = date.AddMonths(2);
            // 1 day, 12 hours later
            date = date.AddDays(1.5);
            // 6 hours prior
            date = date.AddHours(-6);
            // 150 minutes later
            date = date.AddMinutes(150);
            // 10.5 seconds later
            date = date.AddSeconds(10.5);
            // 499 milliseconds later
            date = date.AddMilliseconds(499);
            // 10000 ticks later
            date = date.AddTicks(10000);
        }

        static void DifferenceOfDates()
        {
            DateTime newYears = new DateTime(DateTime.Today.Year + 1, 1, 1);

            DateTime now = DateTime.Today;

            TimeSpan timeUntilNewYears = newYears.Subtract(now);

            // Get last day of month
            // Take this month, on the first, add a month, then subtract a day = last day of month
            DateTime lastDayOfMonth = new DateTime(DateTime.Today.Year, 2, 1).AddMonths(1).AddDays(-1);
            Console.WriteLine(lastDayOfMonth);
            Console.ReadKey();


        }

        static void DayOfWeekAndYear()
        {
            DateTime nextIndependence = new DateTime(DateTime.Today.Year + 1, 7, 4);

            switch (nextIndependence.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine($"In {nextIndependence.Year}, Independence Day falls on the weekend.");
                    break;
                default:
                    Console.WriteLine($"In {nextIndependence.Year}, Independence Day falls on a weekday.");
                    break;
            }

            Console.ReadKey();
        }

        static void ManipulatingDates()
        {
            DateTime now = DateTime.Now;
            DateTime dueDate = now.AddDays(30).AddHours(5);
            /* OR */
            TimeSpan ts = new TimeSpan(30, 5, 0, 0);
            DateTime newDueDate = dueDate.Add(ts);

            // subtract go back 5 days
            DateTime pastDays = now.AddDays(-5);
        }
    }
}
