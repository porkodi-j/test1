using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Program
    {

        static void Main(string[] args)
        {
            
            Car Ford = new Car();
            Ford.color = "Red";

            Car Tesla = new Car();
            Tesla.color = "White";
            

            Console.WriteLine(Ford.color);
            Console.WriteLine(Tesla.color);
            Console.WriteLine(Ford.model);
            Tesla.brake();
            fullThrottle();

            Console.ReadLine();
        }

        static void fullThrottle()
        {
            Console.WriteLine("Car is going as fast as it can");
        }
    }
}
