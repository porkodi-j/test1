
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUniverse
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Welcome to the Universe!!");
            Console.WriteLine("Hello World!");

            string name = "Paru";
            Console.WriteLine(name); //Variable

            int myNum = 15; //long for 8 bytes
            long myNuml = 15000000000L;
            Console.WriteLine(myNuml);
            Console.WriteLine(myNum); //variable

            double myDoubleNum = 5.99D; //float for 8 bytes
            float myNumf = 5.75F;
            Console.WriteLine(myNumf);
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            const int myNum1 = 27; // variable always store the same value
            Console.WriteLine(myNum1);

            string firstName = "Edward";
            string lastName = "Chris";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine("Welcome " + fullName);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            Console.Write("I am grateful to learn this today"); // Checking Write vs WriteLine
            /* The code below will print the words Hello World
            to the screen, and it is amazing */
            Console.Write("I am success");


            //Implicit Casting

            int myInt = 9;
            double myDouble = 9;
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //Explicit Casting
            double myDouble1 = 9.78;
            int myInt1 = (int) myDouble;
            Console.WriteLine(myInt1);
            Console.WriteLine(myDouble1);

            //Coversion

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToInt64(myDouble2));  // convert double to long
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string


           /* Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Username is " +username);*/

            System.Diagnostics.Debug.WriteLine("Test");
            Console.ReadLine();
        }
    }
}
