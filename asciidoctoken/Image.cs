using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    internal class Image : Token
    {
        public Image(string imageUrl) : base(imageUrl) { 
        }

        public string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }
    }
}
