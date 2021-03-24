using System;

namespace _06.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First integer input: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
            }
            catch (FormatException exc)
            {
                Console.WriteLine("ERRRORRRRR");
                Console.WriteLine($"{exc.GetType()} says {exc.Message}");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"{exc.GetType()} says {exc.Message}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }


            Console.WriteLine("Whats your age: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                Console.WriteLine($"Age is: {age}");
            }
            else
            {
                Console.WriteLine("Wrong input format!");
            }

        }
    }
}
