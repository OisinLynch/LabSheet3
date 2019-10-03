using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q4
{
    public class CashRegister
    {
        //Number of items property
        public int NumberOfItems { get; private set; }

        //Total property
        public double Total { get; private set; }

        public void AddItems (double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;
        }
    }
}
