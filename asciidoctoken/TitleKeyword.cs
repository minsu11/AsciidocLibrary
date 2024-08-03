using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    // Level 0 title 밑에 나오는 문법
    // 
    internal class TitleKeyword : Token
    {
        public TitleKeyword(string title) : base(title) {
        }
       
        
        public override string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }
    }
}
