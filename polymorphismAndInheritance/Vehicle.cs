using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAndInheritance
{
    class Vehicle
    {
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double speed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        public int Seats { get; }
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; }

        public Vehicle()
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double speed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.speed = speed;

            distanceTraveled = 0.0d;
        }

        public virtual void Move()
        {
            distanceTraveled += speed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance traveled: " + distanceTraveled + "\n";
        }
    }
}
