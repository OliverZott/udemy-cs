using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.List
{
    class Program
    {
        static void Main()
        {

            int[] numbers = { 1, 2, 3, 4 };
            List<int> listWithAddedNumbers = new() { 5, 6, 7 };

            List<int> listOfNumbers = numbers.ToList();
            listWithAddedNumbers.AddRange(numbers);

            // Output List<>
            listOfNumbers.ForEach(Console.WriteLine);
            Console.WriteLine(new string('-', 50));

            // Output List<>
            foreach (int item in listOfNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));

            // Exercise 1
            string[] list1 = { "item1", "item2", "item3" };
            string[] list2 = { "item4", "item5" };
            ConcatenatingStringArrase(new List<string[]>() { list1, list2 }).ForEach(Console.WriteLine); ;


        }


        public static List<string> ConcatenatingStringArrase(List<string[]> arrays)
        {
            List<string> strings = new();
            foreach (var item in arrays)
            {
                strings.AddRange(item);
            }
            return strings;
        }
    }
}
