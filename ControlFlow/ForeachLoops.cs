using System;
namespace ControlFlow
{
    public class ForeachLoops
    {
        public ForeachLoops()
        {
            var name = "John Doe";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
