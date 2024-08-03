using AsciidocLibrary.asciidoctoken;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.grammar
{
    public class HtmlGrammar : Grammar
    {
        public String accept(Token token)
        {
            return token.ToString();  
        }
    }
}
