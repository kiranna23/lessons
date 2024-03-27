using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson6
{
    abstract class Document
    {
        protected int NumberOfDocument;
        protected DateTime DateOfDocument;

        public virtual string Information()
        {
            return "Number of document: " + NumberOfDocument 
                  + ", date of document: " + DateOfDocument;
        }
    }
}
