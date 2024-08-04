using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * 예시 코드
     * `example`
     */
    internal class InlineCode : Token
    {
        public InlineCode(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
    
}