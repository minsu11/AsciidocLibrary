using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    internal class MarkDown : Parser
    {
        private string str;

        public Parser FileParser(ParserVisitor visitor)
        {
            return visitor.changeMarkDown(this);
        }
        
    }
}
