using System;
using System.Globalization;

namespace WorkingWithText
{
    public class StringsTest
    {
        public StringsTest()
        {
            // String are immutable
            // Each method like Trim or ToUpper, etc returns a new string
            // It does not modify the original string

            var fullname = "Ivan Tabarino ";
            Console.WriteLine($"Trim: '{fullname.Trim()}'");
            Console.WriteLine($"ToUpper: '{fullname.Trim().ToUpper()}'");

            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullname.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var diffName = fullname.Replace("Ivan", "Ivanosvich");
            Console.WriteLine(diffName);

            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "12";
            var intStr = Convert.ToInt32(str);
            Console.WriteLine(intStr);

            var price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
            CultureInfo pt = new CultureInfo("pt-PT");
            Console.WriteLine(price.ToString("C", pt));
        }
    }
}
