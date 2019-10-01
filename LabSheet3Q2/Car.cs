using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q2
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string _model;

        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return this.currentSpeed; }
            set { this.currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make: {Make}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Current Speed: {CurrentSpeed}");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }

        public override string ToString()
        {
            return
                string.Format($"Car Make: {Make}" +
                              $"\nCar Model: {Model}" +
                              $"\nCurrent Speed: {CurrentSpeed}") +
                              $"\nEngine Size: {EngineSize}";
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current speed is: {CurrentSpeed}");
        }

    }
}
