using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp059
{
    // access modifier class className
    public class program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Drive();
            Car.Brake();
        }
    }
}
