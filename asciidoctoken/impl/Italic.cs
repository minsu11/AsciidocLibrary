using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    internal class Italic : Token 
    {
        public Italic(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}