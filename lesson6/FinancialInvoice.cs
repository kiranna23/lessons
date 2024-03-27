using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class FinancialInvoice : Document
    {
        private double MonthlyAmount;
        private int CodeOfDepartament;

        public FinancialInvoice()
        {
            NumberOfDocument = 0;
            DateOfDocument = DateTime.Now;
            MonthlyAmount = 0;
            CodeOfDepartament = 0;
        }

        public FinancialInvoice(int numberOfDocument, DateTime dateOfDocument, double monthlyAmount, int codeOfDepartament)
        {
            NumberOfDocument = numberOfDocument;
            DateOfDocument = dateOfDocument;
            MonthlyAmount = monthlyAmount;
            CodeOfDepartament = codeOfDepartament;
        }

        public override string Information()
        {
            return base.Information() + ", monthly amount: " + MonthlyAmount
                                      + ", code of departament: " + CodeOfDepartament;
        }
    }
}
