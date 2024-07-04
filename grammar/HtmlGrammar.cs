using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.grammar
{
    public class HtmlGrammar : Grammar
    {
        private static Boolean check = false;
        private static readonly string[] htmlGrammarString = new string[5]{ "<h1>", "<h2>","<h3>", "<h4>", "<h5>" };
        public string convertTitle(string content)
        {
            if (!check)
            {
                check = true;

            }  
            return "";
        }

        // adoc 굵은 글씨체 생략된 경우
        public string convertBold(string content)
        {
            return "<b>"+content+"</b>";
        }

    }
}
