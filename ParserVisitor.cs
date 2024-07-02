using System;
using System.Collections.Generic;

namespace AsciidocLibrary
{
    public interface ParserVisitor
    {
        void changeToHtml(HtmlType type);

        void changeToTxt(TextFile textFile);

        
    }
}
