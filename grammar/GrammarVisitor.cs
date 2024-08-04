using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    internal interface GrammarVisitor
    {
        string visit(Token token);
        string visit(Title title);
        string visit(Keyword keywordToken);
        string visit(TitleKeyword titleKeywordToken);

        string visit(Image image);
        string visit(Table table);
        string visit(Italic italic);
        string visit(Monospace monospace);
        string visit(Bold bold);
        string visit(IncludeFile includeFile);
        string visit(NewLine newLine);
        string visit(Content content);
    }
}
