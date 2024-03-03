using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Phone
    {
        string number;
        string model;
        double weight;

        public Phone() 
        {
            number = "";
            model = "";
            weight = 0;
        }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(string number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        } 
        
        public void receiveCall(string name)
        {
            Console.WriteLine(name + " is calling");
        }

        public void receiveCall(string name, string Number)
        {
            Console.WriteLine(name + " is calling from the phone number " + Number);
        }

        public string getNumber()
        {
            return number;  
        }

        public void sendMessage(params string[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Fatal: there aren't parameters!");
            }
            else
            {
                Console.Write("The message was sent to users with phone numbers: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + "  ");
                }
                Console.WriteLine("");
            }
        }

        public void outParameters()
        {
            Console.WriteLine("Number: " + number + ", model: " + model + ", weight: " + weight);
        }
    }
}
