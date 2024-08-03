using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    internal abstract class Token : Grammar
    {
        private string content { get; }

        public Token(string content) { 
            this.content = content;
        }

        public String Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }

    }
}
