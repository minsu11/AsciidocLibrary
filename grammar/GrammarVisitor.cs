using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    public interface GrammarVisitor
    {
        string visit(Token token);
        /**
         * 제목 level에 따른 html 변환
         */
        string visit(Title title);
        /**
         * [%hardbreak]와 같은 ascii doc 문법 변환
         */
        string visit(Keyword keywordToken);
        string visit(TitleKeyword titleKeywordToken);

        string visit(Image image);
        string visit(Table table);
        string visit(Italic italic);
        string visit(Monospace monospace);
        string visit(Bold bold);
        string visit(IncludeFile includeFile);
        string visit(NewLine newLine);
        string visit(AsciiList asciiList);
        string visit(Content content);
    }
}
