using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * 아스키독 테이블
     *  
     */
    internal class Table : Token
    {
        // todo 우선은 테이블 기본 문법만(테이블을 만드는 문법이 너무 많음)
        
        public Table(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}