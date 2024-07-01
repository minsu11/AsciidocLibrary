using System;

namespace AsciidocLibrary
{
    internal interface Parser
    {
        // IComponent
        Parser FileParser(ParserVisitor parser); // visitor accept


    }
}