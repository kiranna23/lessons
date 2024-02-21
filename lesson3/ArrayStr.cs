using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace lesson3
{
    class ArrayStr
    {
        string[] names;

        public ArrayStr()
        {
            names = new string[7] { "Bob", "Tom", "Alice", "Marta", "John", "Anna", "Mike" };
        }

        public void SortArray()
        {
            Array.Sort(names);
        }

        public void Output()
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine("");    
        }

    }
}
