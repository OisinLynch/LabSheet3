using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister();

            Console.WriteLine("Adding an item worth 3.50 to cash register 1");
            Console.WriteLine("Adding an item worth 7.95 to cash register 1");
            Console.WriteLine("Adding an item worth 15.40 to cash register 1");
            cr1.AddItems(3.50);
            cr1.AddItems(7.95);
            cr1.AddItems(15.40);

            Console.WriteLine();

            CashRegister cr2 = new CashRegister();

            Console.WriteLine("Adding an item worth 2.55 to cash register 2");
            Console.WriteLine("Adding an item worth 8.60 to cash register 2");
            Console.WriteLine("Adding an item worth 20.00 to cash register 2");
            Console.WriteLine("Adding an item worth 5.90 to cash register 2");
            cr2.AddItems(2.55);
            cr2.AddItems(8.60);
            cr2.AddItems(20.00);
            cr2.AddItems(5.90);

            Console.WriteLine();

            Console.WriteLine("Cash Register CR1 total: {0}", cr1.Total);
            Console.WriteLine("Cash Register CR1 Number of items: {0}", cr1.NumberOfItems);
            Console.WriteLine("Cash register CR2 total: {0}", cr2.Total);
            Console.WriteLine("Cash register CR2 Number of items: {0}", cr2.NumberOfItems);
        }
    }
}
