using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lesson4
{
    class StrExersice
    {
        string words;

        public StrExersice()
        {
            words = "";
        }

        public StrExersice(string Words) 
        {
           words = Words;  
        } 

        public void Parts(ref string FirstPart, ref string SecondPart)
        {
            string word = "abc";
            int indexOfSubstring = words.IndexOf(word);
            FirstPart = words.Substring(0, indexOfSubstring);
            SecondPart = words.Substring(indexOfSubstring + word.Length); 
        }

        public void SubString()
        {
            string word = "Bad", good = "Good", sign = "!!!!!!!!!";
            int indexOfSubstring = words.IndexOf(word);   
            words = words.Substring(indexOfSubstring + word.Length);
            words = words.Insert(0, good);
            words = words + sign;
            indexOfSubstring = words.LastIndexOf("!");
            words = words.Insert(indexOfSubstring + 1, "?");
        }

        public void ReplaceStr()
        {
            string OldWord = "test";
            string NewWord = "testing";
            string correctString = words.Replace(OldWord, NewWord);
            words = correctString;  
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] >= '0' && words[i] <= '9')
                {
                    words = words.Remove(i, 1);
                }
            }
        }

        public void ConcatStr()
        {
            words += "Welcome " + "to " + "the " + "TMS " + "lessons.";
            Console.WriteLine(words);
        }

        public void OutStr()
        {
            Console.WriteLine(words);
        }
    }
}
