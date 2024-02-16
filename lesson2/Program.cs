using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = 0;
            double result1 = 0;
            bool chet = false;
            string word = "", sign = "", result2 = "";

            //задание 1
            Exercise1 calculator = new Exercise1();
            Console.Write("Введите знак операции: ");
            sign = Console.ReadLine();
            result1 = calculator.Solve(sign);
            if (result1 != 0)
                Console.WriteLine("Результат вычислений: " + result1);

            //задание 2
            Console.Write("Введите число от 0 до 100: ");
            n = Convert.ToInt32(Console.ReadLine());
            Exercise2 interval = new Exercise2(n);
            result2 = interval.Check();
            if (result2 != null)
                Console.WriteLine("Число входит в числовой промежуток: " + result2);

            //задание 3
            Exercise3 dictionary = new Exercise3();
            Console.Write("Введите слово на русском языке: ");
            word = Console.ReadLine();
            result2 = dictionary.Dictionary(word);
            if (result2 != null)
                Console.WriteLine("Перевод слова " + word + " на английский язык: " + result2);
            else
                Console.WriteLine("Введенное слово отсутсвует в словаре.");

            //задание 4
            Console.Write("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            Exercise4 chetnost = new Exercise4(n);
            chet = chetnost.method1();
            if (chet)
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число нечётное");
            Console.ReadKey();
        }
    }
}
