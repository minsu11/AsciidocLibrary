using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    public class BlockElement : Token
    {
        
        
        public BlockElement(string Content) : base(Content) {
        
        }

        public override string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }


    }
}