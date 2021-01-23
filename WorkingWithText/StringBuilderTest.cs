using System;
using System.Text;

namespace WorkingWithText
{
    public class StringBuilderTest
    {
        public StringBuilderTest()
        {
            // StringBuilders are mutable
            // Unlike Strings, StringBuilders don't have IndexOf, Contains, Substring, etc...

            var builder = new StringBuilder("Hello");
            builder.AppendLine()
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            Console.WriteLine(builder);

            var builder2 = new StringBuilder();
            builder2.Append('-', 10);
            builder2.AppendLine();
            builder2.Append('-', 10);
            builder2.Replace('-', '+');
            Console.WriteLine(builder2);

            builder2.AppendLine();
            builder2.Remove(0, 10);
            Console.WriteLine(builder2);

            builder2.AppendLine();
            builder2.Insert(0, new string('-', 10));
            Console.WriteLine(builder2);

            Console.WriteLine("First Char: " + builder2[0]);
        }
    }
}
