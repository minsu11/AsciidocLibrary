using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace AsciidocLibrary.asciidoctoken
{
    internal class Keyword : Token
    {
        private string content;
        // [%hardbreak]와 같은 문법

        public Keyword(string content) : base(content) {
        }

        public override string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }


    }
}
