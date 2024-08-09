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
        private static readonly string Bold_Regex = @"(\*+)([^\* ]+)(\*+)";
        private static readonly string Italic_Regex = @"(\_+)([^\* ]+)(\_+)";
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
            return "<img src=\"";
        }
        
        public string visit(Title title)
        {
            Regex regex = new Regex("[=]{1,6} ");
            return "<h" + title.GetTitleLevel() + ">\n\t" + regex.Replace(title.GetContent(),"") + "\n/<h" + title.GetTitleLevel() + ">\n";
        }

        
        public string visit(Table table)
        {
            return "";
        }

        public string visit(Italic italic)
        {
            // 기울기
            return "<p>\n<I>\n" + italic.GetContent() + "\n</I>\n</p>";

        }

        public string visit(Monospace monospace)
        {
            return "<code>\n" + monospace.GetContent() + "\n</code>\n";
        }

        public string visit(Bold bold)
        {
            return "<b>" + bold.GetContent() + "</b>";
        }

        public string visit(IncludeFile includeFile)
        {
            return "";
        }

        public string visit(NewLine newLine)
        {
            return newLine.GetContent() + "</br>\n";
        }

        /// <summary>
        /// 앞에 문법 없는 글씨.
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string visit(Content content)
        {
            if (
                Regex.Match( content.GetContent(),Bold_Regex).Success ||
                Regex.Match(content.GetContent(),Italic_Regex).Success
                )
            {
                content.SetContent(ConvertPTag(content.GetContent()));
            }
            return "<p>\n"+ content.GetContent()+"\n</p>\n";
        }

       /// <summary>
       /// 목록에 대한 문법에서 갯수가 중요
       /// 
       /// </summary>
       /// <param name="asciiList"></param>
       /// <returns></returns>
        public string visit(AsciiList asciiList)
        {
            // level이 같으면
            for (int i = 0; i < asciiList.GetLevel(); i++)
            {
                string str = "<ul\n><li>\n"+asciiList.GetContent()+"<\n</li>\n<ul>\n";
                asciiList.SetContent(str);
            }
            return asciiList.GetContent();
        }

     
        

        /// <summary>
        /// 글씨, 굵은 글씨, 기울어진 글씨, monospace 등등의 각 속성에 맞게 문자열을 호출
        /// 문자열이 Null이거나 빈 값인 경우 "" 반환함
        /// . ! , ? 같은 특수 문자에 대해서 뒤에 공백 하나 더줌
        /// </summary>
        /// <param name="str">Ascii doc 문법 문장</param>
        /// <returns></returns>
        private string ConvertPTag(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            string[] splitStr = str.Replace("([.,?!])([^ ]+)","$1 $2").Split(" ");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < splitStr.Length; i++)
            {
                if (Regex.Match(splitStr[i],Bold_Regex).Success)
                {
                    sb.Append(visit(new Bold(splitStr[i]+" ")));
                }
                else if (Regex.Match(splitStr[i],Italic_Regex).Success)
                {
                    sb.Append(visit(new Italic(splitStr[i]+" ")));
                }
                else if(i < splitStr.Length-1)
                {
                    sb.Append(splitStr[i] + " ");
                }
                else
                {
                    sb.Append(splitStr[i]);
                }
                
            }


            return sb.ToString();
        }
    }
}
