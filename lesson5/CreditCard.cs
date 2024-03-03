using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class CreditCard
    {
        string accountNumber;
        double amount;

        public CreditCard()
        {
            accountNumber = "";
            amount = 0;
        }

        public CreditCard(string accountNumber, double amount)
        {
            this.accountNumber = accountNumber;
            this.amount = amount;
        }

        public void Refill(double money)
        {
            amount += money;
        }

        public void Withdrawal(double money)
        {
            if (amount - money < 0)
            {
                Console.WriteLine("There aren't enough funds in the our account");
            }
            else
            {
                amount -= money;
                Console.WriteLine("The operation was performed successfully");
            }   
        }

        public void outInformation()
        {
            Console.WriteLine("Account number: " + accountNumber + ", the current amount in the account: " + amount + "$");    
        }
    }
}
