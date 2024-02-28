using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Document
    {
        public static string[] SplitStr(string document)
        {
            char sign = '-';
            string[] words = document.Split(sign);
            return words;   
        }
        public static void BlockNumbers (string document)
        {
            string[] words = SplitStr(document);
            string FirstBlock = words[0];
            string SecondBlock = words[2];
            Console.WriteLine(FirstBlock + " " + SecondBlock);
        }

        public static void ReplaceLetter(string document)
        {
            string[] words = SplitStr(document);
            string FirstBlock = words[1];
            string SecondBlock = words[3];
            string correctString = document.Replace(FirstBlock, "***");
            document = correctString;
            correctString = document.Replace(SecondBlock, "***");
            document = correctString;
            Console.WriteLine(document);
        }

        public static void OutLetters(string document)
        {
            string[] words = SplitStr(document);
            Console.WriteLine(words[1].ToLower() + 
                "/" + words[3].ToLower() + 
                "/" + Char.ToLower(words[4][1]) + 
                "/" + Char.ToLower(words[4][3]));
        }

        public static void OutDocument(string document)
        {
            string[] words = SplitStr(document);
            StringBuilder myStringBuilder = new StringBuilder("Letters:");
            myStringBuilder.Append(words[1].ToUpper() + 
                "/" + words[3].ToUpper() + 
                "/" + Char.ToUpper(words[4][1]) + 
                "/" + Char.ToUpper(words[4][3]));
            Console.WriteLine(myStringBuilder);
        }

        public static bool IncludeABC(string document)
        {
            string[] words = SplitStr(document);
            return (words[1].Contains("abc") || words[1].Contains("ABC") || words[3].Contains("abc") || words[3].Contains("ABC"));
        }

        public static bool IncludeNumbers(string document)
        {
            string[] words = SplitStr(document);
            string line = words[0].Substring(0,3);
            return (line == "555");
        }

        public static bool IncludeCombination(string document)
        {
            string[] words = SplitStr(document);
            return (words[4] == "1a2b");
        }
    }
}
