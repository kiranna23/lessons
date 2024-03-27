using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Commodity : Product
    {
        public Commodity(string name, double price, DateTime manufactureDate, int countOfDays)
        {
            Name = name;
            Price = price;
            DateOfManufacture = manufactureDate;
            CountOfDays = countOfDays;
        }

        public override string Information()
        {
            return base.Information() + ", day of manufacture: " + DateOfManufacture 
                                      + ", days of life: " + CountOfDays;
        }

        public override bool CheckExpirationDate(DateTime CurrentDate)
        {
            return base.CheckExpirationDate(CurrentDate);
        }
    }
}
