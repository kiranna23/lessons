using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class ContractOfEmployee : Document
    {
        private string NameEmployee;
        private DateTime DateEnd;

        public ContractOfEmployee()
        {
            NumberOfDocument = 0;
            DateOfDocument = DateTime.Now;
            NameEmployee = "Nothing";
            DateEnd = DateTime.Now + new TimeSpan(30, 0, 0, 0);
        }

        public ContractOfEmployee(int numberOfDocument, DateTime dateOfDocument, string nameEmployee, DateTime dateEnd)
        {
            NumberOfDocument = numberOfDocument;
            DateOfDocument = dateOfDocument;
            NameEmployee = nameEmployee;
            DateEnd = dateEnd;
        }

        public override string Information()
        {
            return base.Information() + ", employee's name: " + NameEmployee
                                      + ", the end of the contract: " + DateEnd;
        }
    }
}
