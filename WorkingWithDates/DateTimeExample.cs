using System;

namespace WorkingWithDates
{
    public class DateTimeExample
    {
        public DateTimeExample()
        {
            // DateTime Objects are immutable on C#

            var dateTime = new DateTime(2021, 1, 21);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tomorrow = now.AddDays(1);
            Console.WriteLine(tomorrow);

            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
