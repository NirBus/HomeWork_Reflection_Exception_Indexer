using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Reflection_Exception_Indexer
{
    class MainPrintFile : IPrintable
    {
       
        public void Print()
        {
            PDF pdf = new PDF();
            Excel excel = new Excel();
            Word word = new Word();

            if (pdf!=null)
            {
                Console.WriteLine("PDF cap edildi.");
            }
            if (excel != null)
            {
                Console.WriteLine("Excel cap edildi.");
            }
            if (word != null)
            {
                Console.WriteLine("Word cap edildi.");
            }
        }
    }
}
