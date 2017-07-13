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
        protected int capacity;
        protected string color;
        protected double speed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        public int Seats { get; }
        public int Capacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; }

        public Vehicle()
        {

        }

        public Vehicle(int seats, int capacity, string color, double speed)
        {
            this.seats = seats;
            this.capacity = capacity;
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
