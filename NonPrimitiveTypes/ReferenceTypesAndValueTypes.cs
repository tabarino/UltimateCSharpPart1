using System;
namespace NonPrimitiveTypes
{
    public class ReferenceTypesAndValueTypes
    {
        public ReferenceTypesAndValueTypes()
        {
            // Value Types
            // In this case a will be 10 and b will be 11
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a: {a}, b: {b}");

            // Reference Types
            // In this case array1[0] will be 0 and array2[0] will be 0
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");

            // Value Types
            // In this case the number will keep as 1
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            // Reference Types
            // In this case the number will be 11
            var person = new Person() { Age = 1 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public void Increment(int number)
        {
            number += 10;
        }

        public void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

    public class Person
    {
        public int Age;
    }
}
