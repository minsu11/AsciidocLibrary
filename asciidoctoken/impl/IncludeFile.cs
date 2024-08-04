using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * 예시 문법
     * == 문서 내 포함 요소
     * include::included.adoc[]
     * 
     */
    internal class IncludeFile : Token
    {
        public IncludeFile(string content) : base(content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}