using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class MyClass
    {
        string color = "red"; //field
        int maxSpeed = 200; //field
        public void fullThrottle() //method
        {
            System.Console.WriteLine("The caris going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            //System.Console.WriteLine(myObj.color);
            //System.Console.WriteLine(myObj.maxSpeed);

            myObj.fullThrottle();
        }
    }
}