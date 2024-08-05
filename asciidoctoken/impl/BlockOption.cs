using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    public class BlockOption : Token
    {
        /**
         * [%hardbreak]: 줄 바꿈을 하드 브레이크로 처리하여 다음 줄이 바로 이어지게 만듭니다.
         * [%autowidth]: 테이블에서 열 너비를 자동으로 조정합니다.
         * [%header]: 테이블의 첫 번째 행을 헤더 행으로 지정합니다.
         * [%footer]: 테이블의 마지막 행을 푸터 행으로 지정합니다.
         */

        public BlockOption(string Content) : base(Content)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}