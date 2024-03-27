using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Register
    {
        Document[] documents;

        public Register()
        {
            documents = new Document[10];    
        }

        public Register(int n)
        {
            documents = new Document[n];
        }

        public void AddDocument(Document document)
        {
            int index = -1;
            for (int i = 0; i < documents.Length; i++)
            {
                if (documents[i] == null)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                documents[index] = document;
                Console.WriteLine("The document has been added to the register!");
            }
            else
            {
                Console.WriteLine("Register is full");
            }
        }

        public string getInfo(Document document)
        {
            return document.Information();
        }
    }
}

