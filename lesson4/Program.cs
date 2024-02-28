using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrExersice word = new StrExersice("testgo1ofwde3fqdwftestsdac3vtest"); //exercise 1
            word.OutStr();
            word.ReplaceStr();
            word.OutStr();

            StrExersice NewWord = new StrExersice(); //exercise 2
            NewWord.ConcatStr();

            word = new StrExersice("teamwithsomeofexcersicesabcwanttomakeitbetter"); //exercise 3
            string FirstPart = "", SecondPart = "";
            word.Parts(ref FirstPart, ref SecondPart);
            Console.WriteLine("The first part of the line: " + FirstPart + ", the second part of the line: " + SecondPart);

            word = new StrExersice("Bad day"); //exercise 4
            word.OutStr();
            word.SubString();
            word.OutStr();

            Document.BlockNumbers("1234-asx-2345-abc-1s5d"); //5.1
            Document.ReplaceLetter("1234-asx-2345-abc-1s5d"); //5.2
            Document.OutLetters("1234-Asx-2345-aBc-1S5d"); //5.3
            Document.OutDocument("1234-asx-2345-abc-1s5d"); //5.4
            if (Document.IncludeABC("1234-ABC-2345-asd-1S5d")) //5.5
            {
                Console.WriteLine("Document number contains abc");
            }
            else
            {
                Console.WriteLine("Document number doesn't contain abc");
            }
            if (Document.IncludeABC("5554-ABC-2345-asd-1S5d")) //5.6
            {
                Console.WriteLine("Documnent number starts with 555");
            }
            else
            {
                Console.WriteLine("Documnent number doesn't start with 555");
            }
            if (Document.IncludeCombination("5554-ABC-2345-asd-1S5d")) //5.7
            {
                Console.WriteLine("Documnent number ends with 1a2b");
            }
            else
            {
                Console.WriteLine("Documnent number doesn't end with 1a2b");
            }
        }
    }
}
