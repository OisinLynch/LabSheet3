using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            //Call the DisplayCarInfo method
            c1.DisplayCarInfo();

            Console.WriteLine();

            //Call the ToString Method
            Console.WriteLine(c2.ToString());

            Console.WriteLine();

            //Call the accelerate method
            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine();

            Console.WriteLine(c1);

        }
    }
}
