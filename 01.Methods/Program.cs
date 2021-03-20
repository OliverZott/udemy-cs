using System;

namespace _01.Methods
{
    class Program
    {
        static void Main()
        {
            // Variale parameter count
            Console.WriteLine(Sum(3, 4, 5));

            // Variale parameter count
            string name = "Olli";
            string surname = "Zott";
            AwesomePrint("[1] [0]", name, surname);


            // Reference vs Value Types
            Console.WriteLine("------------------ Reference vs Value Types ------------------");
            numbers[1] = 42;
            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }
            number = 2663;
            Console.WriteLine(number);
            Console.WriteLine(number2);

            int num1 = 17;
            int[] nums1 = { 1, 2, 3 };
            ChangeSomething(para1: nums1, ref num1 );
            Console.WriteLine(num1);
            Console.WriteLine(nums1[0]);


            // call-by-reference for value type
            Console.WriteLine("------------------ Call-by-reference for value type ------------------");
            int blub = 0;
            Console.WriteLine(blub);
            IncreaseByOne(ref blub);
            Console.WriteLine(blub);


            // multiple return values
            int outArg1 = 1;
            string outArg2, stillNull;
            OutExample(out outArg1, out outArg2, out stillNull);
            Console.WriteLine("Out example: " + outArg1 + outArg2 + stillNull);

            CalcGeometrieStuff(3, width: 10, out float area, out float perimeter);
            Console.WriteLine($"Area: {area}, Perimeter {perimeter}");

        }


        /**
         * ###############################################################################################
         * Variable argument count
         * ###############################################################################################
         */
        static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }

        // Example
        static void AwesomePrint(string text, params string[] parameters)
        {
            string TempString = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '[')
                {
                    TempString += parameters[int.Parse(text[i + 1].ToString())];
                    i += 2;
                }
                else
                {
                    TempString += text[i];
                }
            }
            Console.WriteLine(TempString);
        }


        /**
         * ###############################################################################################
         * Reference vs Value Types
         * ###############################################################################################
         */
        static int number = 10;
        static int number2 = number;
        static int[] numbers = { 1, 2, 3 };
        static int[] numbers2 = numbers;

        static void ChangeSomething(int[] para1, ref int para2)
        {
            para1[0] = 42;
            para2 = 42;
        }


        /**
         * ###############################################################################################
         * ref ...call-by-reference
         * ###############################################################################################
         */
        static void IncreaseByOne(ref int inputNumber)
        {
            inputNumber++;
        }

        /**
         * ###############################################################################################
         * out ...return multiple values
         * ###############################################################################################
         */

        static void OutExample(out int outArg1, out string outArg2, out string stillNull )
        {
            outArg1 = 19;
            outArg2 = "Hello whats up";
            stillNull = null;
        }
        static void CalcGeometrieStuff(float height, float width, out float area, out float perimeter )
        {
            area = height * width;
            perimeter = 2 * height + 2 * width;
        }



    }
}
