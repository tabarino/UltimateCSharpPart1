using System;
namespace ControlFlow
{
    public class RandomClass
    {
        public RandomClass()
        {
            var random = new Random();

            Console.WriteLine(random.Next());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            // ASC
            Console.WriteLine((int)'a');

            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0, 26)));
            }

            Console.WriteLine();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);

            Console.WriteLine(password);
            Console.WriteLine();
        }
    }
}
