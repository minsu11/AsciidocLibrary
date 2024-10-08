﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    public class GrammarVisitorComponent : GrammarVisitor
    {
        private static readonly string NEW_LINE = "\n";
        private int TABLE_COL = 0;
        
        
        private string[] titleKeywordArr = new[] { "hardbreaks" };
        private static readonly string Bold_Regex = @"(\*+)([^\* ]+)(\*+)";
        private static readonly string Italic_Regex = @"(_+)([^\* ]+)(_+)";
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
           
            // table |[\w]갯수 만큼 제목
            // 또는 [cols="1,2,3"] => cols 안에 칸수 마다

            return new StringBuilder()
                .Append("<table>")
                .Append(NEW_LINE)
                .Append(ConvertTable(table.GetContent()))
                .Append("</table>")
                .Append(NEW_LINE)
                .ToString();
        }

        /// <summary>
        /// table 태그 안에 <thead>, <tbody> 태그 등으로 변환
        /// </summary>
        /// <param name="TableContent"></param>
        /// <returns></returns>
        private string ConvertTable(string TableContent)
        {
            Console.WriteLine(TableContent);
            Console.WriteLine("============");
            
            string[] contentArr = TableContent.Trim().Split("\n");
            StringBuilder sb = new StringBuilder();
            int TableRow = 0;
            if (TABLE_COL == 0)
            {
                TABLE_COL = 1;
                Console.WriteLine(contentArr[0]);
                string[] TableHead = contentArr[0].Split("|");
                TableRow = TableHead.Length;
                sb.Append("<thead>")
                    .Append(NEW_LINE)
                    .Append("<tr>")
                    .Append(NEW_LINE)
;
                for (int i = 0; i < TableHead.Length; i++)
                {
                    if (!string.IsNullOrEmpty(TableHead[i]))
                    {
                        Console.WriteLine(TableHead[i]);
                        sb.Append("<th>")
                            .Append(TableHead[i])
                            .Append("</th>")
                            .Append(NEW_LINE);
                    }
                }

                sb.Append(NEW_LINE)
                    .Append("</tr>")
                    .Append(NEW_LINE)
                    .Append("</thead>")                         
                    .Append(NEW_LINE);
            }

            sb.Append("<tbody>")
                .Append(NEW_LINE);
            
            // col 수가 다르면?
            
            for (int i = 1; i < contentArr.Length; i++)
            {
                string[] bodyElement = contentArr[i].Split("|");
                
                for (int j = 0; j < bodyElement.Length; j++)
                {
                    if (!string.IsNullOrEmpty(bodyElement[j]))
                    {
                        sb.Append("<td>")
                            .Append(bodyElement[j])
                            .Append("</td>")
                            .Append(NEW_LINE);
                    }
                }   
                if (!string.IsNullOrEmpty(contentArr[i]))
                {
                    
                    sb.Append("<td>")
                        .Append(contentArr[i])
                        .Append("</td>")
                        .Append(NEW_LINE);
                }
            }

            sb.Append("</tbody>")
                .Append(NEW_LINE);

            
            return sb.ToString();
        }

        public string visit(Italic italic)
        {
            // 기울기
            return "<p>\n<I>\n" + italic.GetContent() + "\n</I>\n</p>";

        }

        public string visit(InlineCode inlineCode)
        {
            var sb = new StringBuilder();
            
            return sb
                .Append("<code>")
                .Append(NEW_LINE)
                .Append(inlineCode.GetContent())
                .Append(NEW_LINE)
                .Append("</code>")
                .Append(NEW_LINE)
                .ToString();
            
        }
        
        public string visit(Monospace monospace)
        {
            StringBuilder sb = new StringBuilder();
            // test `test`
            return sb.Append("<p>")
                .Append(NEW_LINE)
                .Append("<pre>")
                .Append(monospace.GetContent())
                .Append(NEW_LINE)
                .Append("/pre>")
                .Append("</p>")
                .ToString();
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
