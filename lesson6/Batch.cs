using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Batch : Product
    {
        private int Count;

        public Batch(string name, double price, DateTime manufactureDate, int countOfDays, int count)
        {
            Name = name;
            Price = price;
            DateOfManufacture = manufactureDate;
            CountOfDays = countOfDays;
            Count = count;  
        }

        public override string Information()
        {
            return base.Information() + ", day of manufacture: " + DateOfManufacture 
                                      + ", days of life: " + CountOfDays 
                                      + ", number of products " + Count;
        }

        public override bool CheckExpirationDate(DateTime CurrentDate)
        {
            return base.CheckExpirationDate(CurrentDate);
        }
    }
}
