using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    public class HtmlType : Parser
    {
        private string str;

        public HtmlType(string str)
        {
            this.str = str;
        }
        
        public void FileParser(ParserVisitor visitor)
        {
            visitor.changeToHtml(this);
        }
        
        public string Str
        {
            get { return str; }
            set { str = value; }
        }


    }
}
