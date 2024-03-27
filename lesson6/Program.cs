using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[5]; //exercise 1
            shape[0] = new Triangle(3, 4, 5);
            shape[1] = new Rectangle(2, 5);
            shape[2] = new Rectangle(7, 9);
            shape[3] = new Circle(3);
            shape[4] = new Circle(10);
            double perimetr = 0;
            for (int i = 0; i < shape.Length; i++)
            {
                perimetr += shape[i].getPerimetr();
            }
            Console.WriteLine("The sum of the perimeters of all shapes: " + perimetr);

            Product[] product = new Product[3]; //exercise 2
            product[0] = new Commodity("Cheese", 1.2, Convert.ToDateTime("10.03.2024"), 14);
            product[1] = new Batch("Bread", 25, Convert.ToDateTime("24.03.2024"), 7, 10);
            string[] ListOfProducts = new string[]{ "saw", "hammer", "axe" };
            product[2] = new Kit("Instruments", 30, ListOfProducts);

            DateTime CurrentDate = DateTime.Now;
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].Information());
                Console.WriteLine(product[i].CheckExpirationDate(CurrentDate) ? "Годен" : "Не годен");
            }

            Register register = new Register(); //exercise 3
            ContractOfGoods contractOfGoods = new ContractOfGoods(1, Convert.ToDateTime("10.03.2024"), "Dairy", 10);
            ContractOfEmployee contractOfEmployee = new ContractOfEmployee(2, Convert.ToDateTime("11.03.2024"), "Mike", Convert.ToDateTime("23.03.2025"));   
            FinancialInvoice financialInvoice = new FinancialInvoice(3, Convert.ToDateTime("13.03.2024"), 300, 33);

            register.AddDocument(contractOfEmployee);   
            register.AddDocument(contractOfGoods);
            register.AddDocument(financialInvoice);

            Console.WriteLine(register.getInfo(contractOfEmployee));
            Console.WriteLine(register.getInfo(contractOfGoods));
            Console.WriteLine(register.getInfo(financialInvoice));
        }
    }
}
