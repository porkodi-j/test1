using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Car
    {
        public string color; //Create a field
        public string model;

        // Create class constructor for the Car class
        public Car()
        {
            model = "Mustang";// set the initial value for model
        }

        public void brake()
        {
            Console.WriteLine("Brake is applied");
        }
    }
}
