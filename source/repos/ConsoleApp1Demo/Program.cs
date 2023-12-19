using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int sum = AddTwoNumbers();
                Console.WriteLine($"\nSum of 2 numbers are: {sum}");
                Console.ReadLine();
            }

            public static int AddTwoNumbers()
            {
                Console.WriteLine("Enter the numbers for Math Operations\n");
                Console.WriteLine("Enter the first number\n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the second number\n");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;
                return sum;
            }
        }
    }