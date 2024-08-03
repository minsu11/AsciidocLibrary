using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    internal interface GrammarVisitor
    {
        string visit(Token token);
        string visit(Keyword keywordToken);
        string visit(TitleKeyword titleKeywordToken);

        string visit(Image image);

    }
}
