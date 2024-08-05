using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    // 글씨 기울임
    
    public class Italic : Token 
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