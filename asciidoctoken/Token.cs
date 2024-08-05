using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    public abstract class Token : Grammar
    {
        private string Content;

        protected Token(string Content) { 
            this.Content = Content;
        }

        public virtual string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }

        public string GetContent()
        {
            return Content;
        }

    }
}
