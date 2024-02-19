using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
     class Exercise3
    {
        string[] english = new string[10] {"hot", 
                                          "warm", 
                                          "cold", 
                                          "sunny", 
                                          "cloudy", 
                                          "rain", 
                                          "snow", 
                                          "thunder", 
                                          "frost", 
                                           "fog"};
        string[] russian = new string[10] {"жарко", 
                                           "тепло", 
                                           "холодно", 
                                           "солнечно", 
                                           "облачно", 
                                           "дождь", 
                                           "снег", 
                                           "туман", 
                                           "мороз", 
                                           "туман"};

        public string Dictionary(string word)
        {
            for (int i = 0; i < english.Length; i++)
            {
                if (russian[i] == word)
                { 
                    return english[i]; 
                }
            }
            return null;
        }
    }
}
