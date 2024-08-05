using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * 아스키 독 문법
     * `+test+`
     * html 변환
     * <em><code>test</code></em>
     */
    public class Monospace : Token
    {
        public Monospace(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}