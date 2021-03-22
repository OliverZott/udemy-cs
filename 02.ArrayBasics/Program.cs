using System;
using System.Linq;

namespace _02.ArrayBasics
{
    class Program
    {
        static void Main()
        {

            double[] numbersD = { 1, 2.1, 3, 42, 29, 14, -12, -28, 399.1 };
            int[] numbersI = { 1, 22, 3, 43, 15, 18 };

            // BubbleSort
            int[] bubbleSorted = BubbleSort.BubbleSortAlgorithm(numbersI);

            // ######################################################################################################
            // Different Array Outputs:
            // ######################################################################################################

            // for-loop
            for (int i = 0; i < numbersD.Length; i++)
            {
                Console.WriteLine("numbers[{0}]: {1:F02}", i, numbersD[i]);
            }
            Console.WriteLine(new string('-', 40));

            // for-each
            foreach (double number in numbersD)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(new string('-', 40));

            // String.Join()
            string numbersString = String.Join(", ", numbersI.OrderBy(x => x));
            Console.WriteLine(numbersString);
            Console.WriteLine(new string('-', 40));

            // LINQ + foreach
            var query = numbersD.Where(x => x < 42).OrderBy(a => Math.Abs(a));

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            // ######################################################################################################
            // Clone Arrays
            // ######################################################################################################

            // arrayName.Clone()
            int[] clonedNumbersI = (int[])numbersI.Clone();
            clonedNumbersI[0] = 666;
            Console.WriteLine($"Original array entry: {numbersI[0]}; Cloned array entry: {clonedNumbersI[0]}");
            Console.WriteLine(new string('-', 40));

            // Array.Copy()
            int[] newArray = new int[numbersI.Length];
            Array.Copy(numbersI, newArray, 3);

            // own function
            int[] outputArray2;
            CustomCloneArray(numbersI, out int[] blub, out outputArray2);

            static void CustomCloneArray(int[] inputArray, out int[] outputArray1, out int[] arr2)
            {
                outputArray1 = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    outputArray1[i] = inputArray[i];
                }

                arr2 = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    arr2[inputArray.Length - 1 - i] = inputArray[i];
                }
            }

            // ######################################################################################################
            // Reverse Arrays
            // ######################################################################################################

            // Array.Reverse()
            Array.Reverse(numbersI);
            foreach (int number in numbersI)
            {
                Console.WriteLine(number);
            }

        }
    }
}
