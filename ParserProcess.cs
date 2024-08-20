using AsciidocLibrary.asciidoctoken;
using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsciidocLibrary
{
   public class ParserProcess
   {
       private string ImageDefaultPath;
        private ParserProcess()
        {
        }

        private static string ContentProcess(String content)
        {
            Console.WriteLine("확인");

            // string 값이 empty인지 확인
            checkEmptyString(content);
            
            string[] parserStr = content.Split("\n"); // \n으로 문단 구분
            Util util = new Util();
            // token화
            List<Token> tokens = util.Tokenization(parserStr);
            GrammarVisitor grammarVisitor = new GrammarVisitorComponent();
            StringBuilder sb = new StringBuilder();
            foreach (var token in tokens)
            {
                sb.Append(token.Accept(grammarVisitor));
            }
            return HtmlForm.GetHtmlForm(sb.ToString()); // 이제 여기에 parse한 데이터 집어 넣기
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
