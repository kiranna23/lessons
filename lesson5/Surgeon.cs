using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Surgeon : IDoctor 
    {
        public void toHeal()
        {
            Console.WriteLine("Surgeon's treatment");
        }
    }
}
