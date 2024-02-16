using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
     class Exercise3
    {
        string[] english;
        string[] russian;
        public Exercise3 ()
        {
            english = new string[10];
            russian = new string[10];
            english[0] = "hot"; russian[0] = "жарко";
            english[1] = "warm"; russian[1] = "тепло";
            english[2] = "cold"; russian[2] = "холодно";
            english[3] = "sunny"; russian[3] = "солнечно";
            english[4] = "cloudy"; russian[4] = "облачно";
            english[5] = "rain"; russian[5] = "дождь";
            english[6] = "snow"; russian[6] = "снег";
            english[7] = "thunder"; russian[7] = "гром";
            english[8] = "frost"; russian[8] = "мороз";
            english[9] = "fog"; russian[9] = "туман";
        }
        public string Dictionary (string word)
        {
            for (int i = 0; i < english.Length; i++)
            {
                if (russian[i] == word)
                    return english[i];
            }
            return null;
        }

    }
}
