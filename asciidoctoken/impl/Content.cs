using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AsciidocLibrary.grammar;

namespace AsciidocLibrary.asciidoctoken
{
    // <p> 내용 </p>
    public class Content : Token
    {
        private Bold[] Bold;
        private string[] SplitString;


       

        public Content(string content) : base(content)
        {
         
        }

        private void Init(string Content)
        {
            string boldRegex = TokenRegex.GetRegex(RegexExpression.BoldContent);
            Regex regex = new Regex(boldRegex);
            if (regex.Match(Content).Success)
            {
                SplitString = Content.Split(boldRegex);
                int i = 0;
                foreach (var bold in regex.Matches(Content).ToArray())
                {
                    Bold[i] = new Bold(bold.ToString());
                    i++;
                }
            }
        }
        
        
        public override string Accept(GrammarVisitor visitor)
        {
            return visitor.visit(this);
        }

        public Boolean isExitBold()
        {
            return Bold.Length > 0;
        }

        public string[] GetSplitString()
        {
            return SplitString;
        }
        
        public Bold[] GetBold()
        {
            return Bold;
        }

      
    }
}