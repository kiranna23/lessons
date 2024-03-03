using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lesson5
{
    class ATM
    {
        int NominalValueIs20;
        int NominalValueIs50;   
        int NominalValueIs100;  
        
        public ATM(int NominalValue20, int NominalValue50, int NominalValue100)
        {
            this.NominalValueIs20 = NominalValue20;
            this.NominalValueIs50 = NominalValue50; 
            this.NominalValueIs100 = NominalValue100;   
        }

        public void addMoney(int countOf20, int countOf50, int countOf100)
        {
            NominalValueIs20 += countOf20;  
            NominalValueIs50 += countOf50;
            NominalValueIs100 += countOf100;    
        }

        public bool Withdrawal(int money)
        {
            int count = 0;
            var atm = new Dictionary<int, int>()
            {
                {100, NominalValueIs100},
                {50, NominalValueIs50},
                {20, NominalValueIs20}
            };
            var atmNew = atm.ToDictionary(entry => entry.Key, entry => entry.Value);

            if (NominalValueIs20 * 20 + NominalValueIs50 * 50 + NominalValueIs100 * 100 > money)
            {
                foreach (var item in atm)
                {
                    count = money / item.Key;
                    if (count > item.Value)
                    {
                        money -= item.Value * item.Key;
                        atmNew[item.Key] = 0;  
                    }
                    else
                    {
                        money -= count * item.Key;
                       atmNew[item.Key] -= count; 
                    }
                }
                if (money != 0)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("100: " + (NominalValueIs100 - atmNew[100])
                                       + " 50: " + (NominalValueIs50 - atmNew[50])
                                       + " 20: " + (NominalValueIs20 - atmNew[20]));
                    NominalValueIs100 = atmNew[100];
                    NominalValueIs50 = atmNew[50];
                    NominalValueIs20 = atmNew[20];
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

