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
            Precondition(Content);
            this.Content = Content;
        }

        public virtual string Accept(GrammarVisitor grammarVisitor)
        {

            return grammarVisitor.visit(this);
        }

        private void Precondition(string Content)
        {
            if (Content == null)
            {
                throw new ArgumentNullException(Content,"Token Content is null");
            } 
        }

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string Content)
        {
            this.Content = Content;
        }
    }
}
