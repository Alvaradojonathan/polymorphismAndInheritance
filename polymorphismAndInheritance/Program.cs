using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance means classes inherit properties or methods from a parent class.
            //e.g.
            //Trasnportation(Base/Parent Class)            Car(Derived/Sub/Child Class):Transportation
            //-capacity                                     This class would inherit all of 
            //-go                                           <- the properties in transportation.
            //-stop 
            //-reverse    
            //-turn

            Boat boat1 = new Boat(2,500,"white and yellow",70.0d,.78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled());
        }
    }
}
