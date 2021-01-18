using System;

namespace NonPrimitiveTypes
{
    public class ClassPerson
    {
        // Classes are Reference Types

        // Reference Types
        // - You need to allocate memory using the "new"
        // - Memory allocated on heap
        // - Garbage collected by CLR

        // Classes and Structures have three basic differences:
        // - Classes are reference types and structs are value types;
        // - Structures do not support inheritance;
        // - Structures cannot have default constructor.

        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}
