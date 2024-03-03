using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Dentist : IDoctor
    {
        public void toHeal()
        {
            Console.WriteLine("Dentist's treatment");
        }
    }
}
