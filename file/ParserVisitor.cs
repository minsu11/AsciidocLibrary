using System;
using System.Collections.Generic;

namespace AsciidocLibrary
{
    internal interface ParserVisitor
    {
        HtmlType changeToHtml(HtmlType type);

        
    }
}
