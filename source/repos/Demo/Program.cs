using System;
using System.Security.Cryptography;
using MathLibrary;

namespace MathOperationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Math Operations\n");
            Console.WriteLine("===================================\n");

            //Math Operations

            //Input
            Console.WriteLine("Enter the numbers for Math Operations\n");
            Console.WriteLine("Enter the first number\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the second number\n");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Operations 
            int sum = math.Add(num1, num2);
            int difference = math.Subtract(num1, num2);
            int product = math.Multiply(num1, num2);
            int quotient = math.Divide(num1, num2);
            Console.WriteLine($"\nSum of numbers: {sum}");
            Console.WriteLine($"\nDifference of numbers: {difference}");
            Console.WriteLine($"\nMultiplication of numbers: {product}");
            Console.WriteLine($"\nDivision of numbers: {quotient}");

            // To find odd or even
            Console.WriteLine("\n===================================\n");
            Console.WriteLine("\nEnter the number to find out odd or even\n");
            Console.WriteLine("Enter the number\n");
            int num3 = Convert.ToInt32(Console.ReadLine());

            bool oddEven = math.FindOddEven(num3);

            string result = (oddEven == true) ? "\nNumber is odd" : "\nNumber is even";
            Console.WriteLine(result);


            Console.WriteLine("\nPress any key to exit\n");

            Console.ReadKey();

        }
    }
}