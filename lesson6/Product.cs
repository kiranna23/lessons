using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    abstract class Product
    {
        protected string Name;
        protected double Price;
        protected DateTime DateOfManufacture;
        protected int CountOfDays;

        public virtual string Information()
        {
            return "Name: " + Name + ", price: " + Price;
        }

        public virtual bool CheckExpirationDate (DateTime CurrentDate)
        {
            return (CurrentDate < DateOfManufacture + new TimeSpan(CountOfDays, 0, 0, 0));  
        }
    }
}
