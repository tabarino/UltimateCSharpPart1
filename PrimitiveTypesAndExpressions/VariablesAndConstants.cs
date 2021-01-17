using System;

namespace PrimitiveTypesAndExpressions
{
    public class VariablesAndConstants
    {
        const float Pi = 3.14f;

        public VariablesAndConstants()
        {
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Ivan";
            //bool isWorking = true;

            // C# automatically set the correct type for you
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Ivan";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} to {1}", byte.MinValue, byte.MaxValue);

            Console.WriteLine(Pi);
        }
    }
}
