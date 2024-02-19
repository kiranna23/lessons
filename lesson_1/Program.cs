using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
