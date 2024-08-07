using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    public class AsciiList : Token
    {
        public AsciiList(string Content) : base(Content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
        
    }
}