using AsciidocLibrary.asciidoctoken;
using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    internal class ParserProcess
    {
        private ParserProcess()
        {
        }

        private static string ContentProcess(String content)
        {
            // string 값이 empty인지 확인
            checkEmptyString(content);
            
            string[] parserStr = content.Split("\n"); // \n으로 문단 구분

            return HtmlForm.GetHtmlForm(""); // 이제 여기에 parse한 데이터 집어 넣기
        }

        public static string Process(string content)
        {
            return ContentProcess(content);
        }

        private static void checkEmptyString(string content)
        {
            if (isEmpty(content))
            {
                throw new ArgumentNullException();
            }
        }

        private static Boolean isEmpty(string content)
        {
            return string.IsNullOrEmpty(content);
        }
        


        
    }
}
