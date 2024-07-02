using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    public class ParserComponent : ParserVisitor
    {
        public void changeToHtml(HtmlType html)
        {
            
            Console.WriteLine("parser component");
        }

        public void changeToTxt(TextFile txt)
        {
            Console.WriteLine("txt");
        }
      
        
    }
}
