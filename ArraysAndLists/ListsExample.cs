using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    public class ListsExample
    {
        public ListsExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // IndexOf
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // Add
            numbers.Add(1);
            Console.WriteLine("Add()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // LastIndexOf
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            // AddRange
            numbers.AddRange(new int[3] { 5, 6, 7 });
            Console.WriteLine("AddRange()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Count
            Console.WriteLine("Count: " + numbers.Count);

            // Remove
            // Be careful: We cannot modify a List inside a foreach loop
            // We have to use for loop to do that
            //foreach (var number in numbers)
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            Console.WriteLine("Remove()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Clear - Removes all elements from the List
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
