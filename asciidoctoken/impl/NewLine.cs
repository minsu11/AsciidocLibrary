using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    public class NewLine : Token
    {
        /**
         * 아스키독 문법에 newLine 속성이 없는 경우에 뒤에 + 붙으면 newLine
         * 예제 코드)
         * test +
         * test1
         * =====> 결과 값
         * test
         * test1
         */
        public NewLine(string newLine) : base(newLine)
        {
        }

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
