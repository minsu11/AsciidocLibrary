using System;
using System.Collections.Generic;

namespace AsciidocLibrary
{
    internal interface ParserVisitor
    {
         MarkDown changeMarkDown(MarkDown str);

         TextFile changeTextFile(TextFile str);


        
    }
}
