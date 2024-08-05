using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    public class Image : Token
    {
        public Image(string imageUrl) : base(imageUrl) { 
        }

        public override string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }
    }
}
