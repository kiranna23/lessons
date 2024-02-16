using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Exercise4
    {
        int n;
        public Exercise4(int m) { n = m; }
        public Exercise4() { n = 0; }
        public bool method1()
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        public bool method2()
        {
            string number = Convert.ToString(n);
            char symbol = number[number.Length - 1];
            if (symbol == '0' || symbol == '2' || symbol == '4' || symbol == '6' || symbol == '8')
                return true;
            else
                return false;
        }

    }
}
