using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAndInheritance
{
    class Boat:Vehicle
    {
        private double waterDrag;

        public Boat(int seats, int carryingCapacity, string color, double speed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.speed = speed;
            this.waterDrag = waterDrag;
        }

        public override void Move()
        {
            distanceTraveled += speed * waterDrag;
        }
    }
}
