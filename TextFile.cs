using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    public class TextFile : Parser
   {
        public void FileParser(ParserVisitor parser)
        {

             parser.changeToTxt(this);
        }
        

        
    }
}
