using System;
using System.Collections.Generic;
using System.Drawing;

namespace _04.MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------------------------------------------------------------------------------------------------------------
            // Example 3 - Picture
            // ------------------------------------------------------------------------------------------------------------
            byte[,,] colors = new byte[3, 1080, 1920];


            Random rng = new Random();
            for (int color = 0; color < colors.GetLength(0); color++)
            {
                for (int row = 0; row < colors.GetLength(1); row++)
                {
                    for (int column = 0; column < colors.GetLength(2); column++)
                    {
                        colors[color, row, column] = (byte)rng.Next(0, 255);
                    }
                }
            }

            Bitmap bitmapImage = new Bitmap(colors.GetLength(2), colors.GetLength(1), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int col = 0; col < colors.GetLength(2); col++)
            {
                for (int row = 0; row < colors.GetLength(1); row++)
                {
                    bitmapImage.SetPixel(col, row, Color.FromArgb(colors[0, row, col], colors[1, row, col], colors[2, 0, 0]));
                }


            }
            bitmapImage.SetPixel(0, 0, Color.FromArgb(colors[0, 0, 0], colors[1, 0, 0], colors[2,0,0]));
            bitmapImage.Save("test.png");

            // ------------------------------------------------------------------------------------------------------------
            // Example 2 - Array Challenge
            // ------------------------------------------------------------------------------------------------------------
            /*
            int N = 4;
            int[,] matrixOne = new int[N, N];
            int[,] matrixTwo = new int[N, N];
            int[,] matrixThree = new int[N, N];
            int number = 1;

            for (int i = 0; i < matrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOne.GetLength(1); j++)
                {
                    matrixOne[i, j] = number;
                    number++;
                }

            }

            int number2 = 1;
            for (int i = 0; i < matrixTwo.GetLength(0); i++)
            {
                for (int j = 0; j < matrixThree.GetLength(1); j++)
                {
                    matrixTwo[j, i] = number2;
                    number2++;
                }

            }

            int number3 = 1;
            int k = 1;
            for (int i = matrixThree.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < k; j++)
                {
                    matrixThree[j, i] = number;
                    number3++;
                }

                k++;
            }

            // Output
            printMatrix(matrixOne);
            printMatrix(matrixTwo);

            void printMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j],3}");
                    }
                    Console.WriteLine();
                }
            }





            // ------------------------------------------------------------------------------------------------------------
            // Example 1
            // ------------------------------------------------------------------------------------------------------------
            Random rng = new Random();

            int years = 3;
            int months = 12;
            int days = 31;
            int hours = 24;

            // List to add arbitrary amount years 
            List<int[,,]> temperatures = new List<int[,,]>()
            {
                new int[months, days, hours]
            };


            for (int year = 0; year < years; year++)
            {
                temperatures.Add(new int[months, days, hours]);

                for (int month = 0; month < temperatures[year].GetLength(0); month++)
                {
                    for (int day = 0; day < temperatures[year].GetLength(1); day++)
                    {
                        for (int hour = 0; hour < temperatures[year].GetLength(2); hour++)
                        {
                            temperatures[year][month, day, hour] = rng.Next(-20, 40);
                        }
                    }

                }

            }
            */
        }

    }
}
