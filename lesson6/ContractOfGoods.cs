using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson6
{
    class ContractOfGoods : Document
    {
        private string TypeOfGoods;
        private int CountOfGoods;

        public ContractOfGoods()
        {
            NumberOfDocument = 0;
            DateOfDocument = DateTime.Now;
            TypeOfGoods = "Nothing";
            CountOfGoods = 0;
        }

        public ContractOfGoods(int numberOfDocument, DateTime dateOfDocument, string typeOfGoods, int countOfGoods)
        {
            NumberOfDocument = numberOfDocument;
            DateOfDocument = dateOfDocument;    
            TypeOfGoods = typeOfGoods;
            CountOfGoods = countOfGoods;
        }

        public override string Information()
        {
            return base.Information() + ", type of goods: " + TypeOfGoods
                                      + ", count of goods: " + CountOfGoods;
        }
    }
}
