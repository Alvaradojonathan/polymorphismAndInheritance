using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAndInheritance
{
    class Dishwasher:Appliances
    {
        public override void Clean()
        {
            Console.WriteLine("Im clean!");
        }
        public override void Rinse()
        {
            Console.WriteLine("I'm in rinse mode");
        }
    }
}
