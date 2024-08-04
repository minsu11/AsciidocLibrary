using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    // <p> 내용 </p>
    internal class Content : Token
    {
        public Content(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}