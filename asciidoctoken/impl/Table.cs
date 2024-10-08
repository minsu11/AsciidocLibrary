using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * 아스키독 테이블
     *  
     */
    public class Table : Token
    {
        // todo 우선은 테이블 기본 문법만(테이블을 만드는 문법이 너무 많음)

        private string TableHead;
        public Table(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }

        public string GetTableHead()
        {
            return this.TableHead;
        }

        public void SetTableHead(string TableHead)
        {
            this.TableHead = TableHead;
        }
    }
}