using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    public abstract class Token : Grammar
    {
        public String accept(Token token) {
            return ""; 
        }
    }
}
