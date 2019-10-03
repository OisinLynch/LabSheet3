using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q5
{
    class CashRegister
    {
        //Static property for total money
        public static double totalMoneyAllCrs { get; set; }

        //Static property for total items
        public static int totalItemsAllCrs { get; set; }

        //Number of items property
        public int NumberOfItems { get; private set; }

        //Total property
        public double Total { get; private set; }

        public void AddItems(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;

            totalItemsAllCrs++;
            totalMoneyAllCrs += itemPrice;
        }
    }
}
