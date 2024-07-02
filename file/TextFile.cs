using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    internal class TextFile : Parser
   {
        public Parser FileParser(ParserVisitor parser)
        {

            return parser.changeTextFile(this);
        }
        

        
    }
}
