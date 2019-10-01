using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q1
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

        private string engineSize;

        public string EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }

        
    }
}
