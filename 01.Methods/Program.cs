using System;

namespace _01.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3, 4, 5));

            string name = "Olli";
            string surname = "Zott";
            AwesomePrint("[1] [0]", name, surname);

        }


        // Variable ammount of arguments
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
    }
}
