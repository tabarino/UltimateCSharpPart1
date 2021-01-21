using System;

namespace WorkingWithDates
{
    public class TimeSpanExample
    {
        public TimeSpanExample()
        {
            // TimeSpan Objects are immutable on C#

            // Creating TimeSpan Objects
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine(timeSpan1);

            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add / Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // Conversion to string
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Conversion from string (Parse)
            Console.WriteLine("Parse: " + TimeSpan.Parse("23:30:32"));
        }
    }
}
