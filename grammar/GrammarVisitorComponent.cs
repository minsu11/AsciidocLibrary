using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    internal class GrammarVisitorComponent : GrammarVisitor
    {
        public string visit(Token token)
        {
            return "";
        }
        public string visit(Keyword keywordToken)
        {
            return "";
        }
        public string visit(TitleKeyword titleKeywordToken)
        {

            return "";
        }
        public string visit(Image image)
        {
            return "";
        }

    }
}
