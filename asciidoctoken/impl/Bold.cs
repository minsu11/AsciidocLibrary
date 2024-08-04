using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    internal class Bold : Token
    {
        public Bold(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor grammarVisitor)
        {

            return grammarVisitor.visit(this);
            
        }
    }
}