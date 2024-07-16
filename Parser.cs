using System;

namespace AsciidocLibrary
{
    public interface Parser
    {
        void FileParser(ParserVisitor parser); // visitor accept

    }
}
