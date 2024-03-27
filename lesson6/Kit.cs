using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Kit : Product
    {
        private string[] Products;

        public Kit(string name, double price, string[] products)
        {
            Name = name;
            Price = price;
            Products = products;    
        }

        public override string Information()
        {
            string ListOfProducts = "";
            for (int i = 0; i < Products.Length; i++)
            {
                ListOfProducts += Products[i] + " ";
            }
            return base.Information() + ", list of products: " + ListOfProducts;
        }

        public override bool CheckExpirationDate(DateTime CurrentDate)
        {
            return true;
        }
    }
}
