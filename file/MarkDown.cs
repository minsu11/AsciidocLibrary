using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    internal class HtmlType : Parser
    {
        private string str;

        public HtmlType(string str)
        {
            this.str = str;
        }
        
        public Parser FileParser(ParserVisitor visitor)
        {
            return visitor.changeToHtml(this);
        }
        
        public string Str
        {
            get { return str; }
            set { str = value; }
        }


    }
}
