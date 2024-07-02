using System;

namespace AsciidocLibrary
{
    internal interface Parser
    {
        Parser FileParser(ParserVisitor parser); // visitor accept


    }
}