using System;
using System.Text.RegularExpressions;
using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    //([\[]{1}[\wㄱ-ㅎ가-힣 ]+[=]{1}[\wㄱ-ㅎ가-힣", ]+[\]]{1}[\n])([|][=])
    public class AsciiList : Token
    {
        private int level;
        public AsciiList(string Content) : base(Content)
        {
            level = Regex.Match(this.GetContent(),"[\\\\*]+|[.]+|[-]+").Length;
        }
        
        
        

        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }

        public int GetLevel()
        {
            return this.level;
        }
        
    }
}