using System;

namespace NonPrimitiveTypes
{
    public class StringsExample
    {
        public StringsExample()
        {
            var firstName = "Ivan";
            var lastName = "Tabarino";
            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            Console.WriteLine(string.Concat("My name is ", firstName, " ", lastName));

            var names = new string[3] { "Jack", "John", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths:\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            var varbatimString = @"Hi John
Look into the following paths:
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(varbatimString);
        }
    }
}
