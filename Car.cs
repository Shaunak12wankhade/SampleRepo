using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp059
{
    class Car
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public static void Brake()
        {
            Console.WriteLine("Brake");
        }
        static void main(string[] args)
        {
            Car myObj = new Car();
            myObj.Drive();
            Brake();
            Console.Read();
        }
    }
}
