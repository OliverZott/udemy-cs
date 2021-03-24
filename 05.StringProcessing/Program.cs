using System;
using System.Linq;
using System.Text;

namespace _05.StringProcessing
{
    class Program
    {
        static void Main()
        {

            // .Split()
            string name = "  @  Oll kik ";
            string names = "one two three";
            string names2 = "one1, two2, three3";

            string[] splitNames = names.Split();
            string[] splitNames2 = names2.Split(", ");
            splitNames2.ToList().ForEach(i => Console.WriteLine(i));


            // .Trim()
            string nameTrimmed = name.Trim(new char[] { ' ', 'k' });
            Console.WriteLine(nameTrimmed);


            // Removing chars with char-array and Stream
            char[] charactersToTrim = " $@k".ToCharArray();
            var cleandName = new string(name.Where(c => !charactersToTrim.Contains(c)).ToArray());
            Console.WriteLine($"Cleaned name: {cleandName}");


            // StringBuilder example
            DateTime start = DateTime.Now;
            string testOne = Concatenator("a", 200000);
            DateTime end = DateTime.Now;
            Console.WriteLine($"Time: {end-start} for concatenation");
            DateTime start2 = DateTime.Now;
            string testTwo = ConcatenatorSB("a", 20000000).ToString();
            DateTime end2 = DateTime.Now;
            Console.WriteLine($"Time: {end2 - start2} for concatenation");


            static string Concatenator(string input, int count)
            {
                string concatinatedString = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    concatinatedString += input;
                }

                return concatinatedString;
            }

            static StringBuilder ConcatenatorSB(string input, int count)
            {
                StringBuilder sb = new();

                for (int i = 0; i < count; i++)
                {
                    sb.Append(input);
                }
                return sb;
            }

        }
    }
}
