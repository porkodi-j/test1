using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program2
    {
        static void Main()
        {
            // Define two numbers for demonstration
            int number1 = 10;
            int number2 = 5;

            // Perform arithmetic operations
            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2;
            int quotient = number1 / number2;
            int remainder = number1 % number2;

            // Display the results

            Console.WriteLine($"QM Syllabus - Demo");

            Console.WriteLine($"Number 1: {number1}");
            Console.WriteLine($"Number 2: {number2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
