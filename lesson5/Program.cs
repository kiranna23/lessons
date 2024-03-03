using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone apple = new Phone("+375446451212", "Apple iPhone 13", 174); //exercise 1
            Phone xiaomi = new Phone("+375296051318", "Xiaomi Redmi 10C", 190.5);
            Phone honor = new Phone("+375296555390", "Honor 90 Lite", 179);

            apple.outParameters();
            xiaomi.outParameters();
            honor.outParameters();

            apple.receiveCall("Mike");
            xiaomi.receiveCall("Bella");
            honor.receiveCall("Sasha");

            apple.getNumber();
            xiaomi.getNumber();
            honor.getNumber();

            apple.receiveCall("Denis", "+375448002352");
            apple.sendMessage("+375296774532", "+375448564545", "+375297885676");

            CreditCard firstCard = new CreditCard("2222 0000 3454 1390 0001", 234); //exercise 2
            CreditCard secondCard = new CreditCard("2323 4455 8567 2004 5698", 1204.67);
            CreditCard thirdCard = new CreditCard("7788 5674 3423 7583 2828", 567.99);

            firstCard.Refill(44.89);
            secondCard.Refill(160);
            thirdCard.Withdrawal(67.99);

            firstCard.outInformation();
            secondCard.outInformation();
            thirdCard.outInformation();

            ATM atm = new ATM(5, 5, 5); //exercise 3
            bool result = atm.Withdrawal(420);
            if (result)
            {
                Console.WriteLine("The operation of withdrawal was completed successfully");
            }
            else
            {
                Console.WriteLine("There aren't enough funds in the ATM for withdrawal money");
            }

            Patient patient = new Patient("Alex", 1); //exercise 4
            patient.Treatment();   
        }
    }
}
