
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;



namespace HelloWorld
{
    class Program1
    {

        //method declaration
        static string myMethod()
        {
            string message = "Hello World";
            return message;
        }

        static void nameGet(string fname = "Paru", int age = 26)
        {
            Console.WriteLine("Name is " +fname+ " and age is " +age);
        }

        static int sum(int a, int b)
        {
            return a + b;
            
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void namedArg(string name1, string name2, string name3)
        {
            Console.WriteLine("Fullname is" + name1);
        }

        static void Main(string[] args)
        {
            // call method
            string message1 = myMethod();
            Console.WriteLine(message1);

            nameGet("Abel", 22);
            nameGet("Sakthi", 18);
            nameGet("Kathir", 11);
            nameGet();

            int z = sum(1, 2);
            Console.WriteLine(z);
            Console.WriteLine(sum(10, 20));

            namedArg(name1: "Porkodi", name2: "Jaya", name3: "Chandran");


            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(8.1, 5.2);
            Console.WriteLine("Int: " +myNum1);
            Console.WriteLine("Double: " +myNum2);

            //2 dimensional array int[,]

            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
           // numbers[0, 0] = 5;
            Console.WriteLine(numbers[0, 0]);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int i =0; i<numbers.GetLength(0);i++) //In array, Use GetLength() instead of Length()
            {
                for (int j=0; j<numbers.GetLength(1);j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            //string[,,] characters = { { "a", "b" }, { "a", "b" }, { "a", "b" } };

            Console.ReadLine();

        }

       
    }
}




