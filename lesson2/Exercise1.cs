using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Exercise1
    {
        double operand1;
        double operand2;   
        public Exercise1 ()
        {
            operand1 = 15;   
            operand2 = 9;   
        }
        public double Solve (string sign)
        {
            switch (sign)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2; 
                case "*":
                    return operand1 * operand2; 
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на нуль!");
                        return 0;
                    }  
                    else
                        return operand1 / operand2;
                default:
                    Console.WriteLine("Ошибка: неизвестный знак!");
                    return 0;
            }
        }

    }
}
