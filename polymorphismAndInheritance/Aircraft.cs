using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAndInheritance
{
    class Aircraft:Vehicle
    {
        private double altitude;

        public double Altitude { get; }

        public Aircraft()
        {
            //Default
        }

        public Aircraft(int seats, int carryingCapacity, string color, double speed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.speed = speed;

            altitude = 0.0d;
        }

        public override void Move()
        {
            altitude += 1000.0d;
            base.Move();
        }
        public override string GetDistanceTraveled()
        {
            return "Altitude: " + altitude + "-" + GetDistanceTraveled();
        }
    }

}

