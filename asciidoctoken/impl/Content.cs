using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    // <p> 내용 </p>
    public class Content : Token
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