using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    public class GrammarVisitorComponent : GrammarVisitor
    {
        private string[] titleKeywordArr = new[] { "hardbreaks" };
        public string visit(Token token)
        {
            return "";
        }
        public string visit(Keyword keywordToken)
        {
            
            return "";
        }
        public string visit(TitleKeyword titleKeywordToken)
        {
            
            return "";
        }
        public string visit(Image image)
        {
            // link가 포함이 있으면 a 태그 추가
            return "<img src";
        }
        
        public string visit(Title title)
        {
            Regex regex = new Regex("[=]{1,6} ");
            return "<h" + title.GetTitleLevel() + ">\n\t" + regex.Replace(title.GetContent(),"") + "\n/<h" + title.GetTitleLevel() + ">\n";
        }

        
        public string visit(Table table)
        {
            throw new NotImplementedException();
        }

        public string visit(Italic italic)
        {
            throw new NotImplementedException();
        }

        public string visit(Monospace monospace)
        {
            throw new NotImplementedException();
        }

        public string visit(Bold bold)
        {
            return "<b>" + bold.GetContent() + "</b>\n";
        }

        public string visit(IncludeFile includeFile)
        {
            throw new NotImplementedException();
        }

        public string visit(NewLine newLine)
        {
            return newLine.GetContent() + "</br>\n";
        }

        public string visit(Content content)
        {
            // string[] contentSplit = content.GetContent().Split("[^\\wㄱ-ㅎㅏ-ㅣ가-힣\\*]*");
            // StringBuilder sb = new StringBuilder();
            // Regex regex = new Regex(TokenRegex.GetRegex(RegexExpression.BoldContent));
            // int idx = 0;
            // foreach (var str in contentSplit)
            // {
            //     Console.WriteLine("       "+str); 
            //     if (regex.Match(str).Success)
            //     {
            //         sb.Append(visit(new Bold(str)));
            //     }
            //
            //     
            //     sb.Append(str+" ");
            //     idx++;
            // }
            Regex regex = new Regex("\\*(.*?)\\*");
            

            return "<p>\n"+regex.Replace(content.GetContent(),"<b>$1</b>\n")+"</p>\n";

        }

    }
}
