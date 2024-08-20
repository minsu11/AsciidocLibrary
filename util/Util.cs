using AsciidocLibrary.asciidoctoken;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;

namespace AsciidocLibrary
{
    public class Util
    {   //todo 정규식 사용해서 토큰화 => 
        // 굵기나 기울임 이런거를 replace를 해서 미리 
        // toc일 경우엔 어떻게 할 것인가
        // toc이면 전체 제목에 대해 목차를 생성 해줘야하는데
        // s
        private static readonly string TITLE_CONTENT_REGEX = "[={1,6}] [\\wㄱ-ㅎㅏ-ㅣ가-힣]*";
        private static readonly string BOLD_CONTENT = "[\\*\\[\\w]*[\\*]";
        private static readonly string KEYWORD_REGEX_STRING = "[\\[]{1}[\\wㄱ-ㅎㅏ-ㅣ가-힣]*[\\]]{1}";
        private static readonly string TITLE_KEYWORD_REGEX_STRING = "[\\:]{1}[\\wㄱ-ㅎㅏ-ㅣ가-힣]*[\\:]{1}";
        private static readonly string LIST_REGEX_STRING = "([^\\wㄱ-ㅎ가-힣\\n])*([\\\\*]+|[.]+|[-]+) ([\\wㄱ-ㅎ가-힣 ]+)";
        private static readonly string INLINECODE_REGEX_STRING = "(`{1,2})[\\wㄱ-ㅎ가-힣]+\\1";

        private static readonly string TABLE_REGEX_STRING = "[|][=]+";
        
        private static List<Token> tokenList = new List<Token>();
        private static readonly Regex KEYWORD_REGEX= new Regex(KEYWORD_REGEX_STRING);
        // 제목 밑 keyword
        private static readonly Regex TITLE_KEYWORD_REGEX = new Regex(TITLE_KEYWORD_REGEX_STRING);
 
        // toc 메서드 있는 지 유무
        private string[] tocTitle;
        
        public Util() { 
            
        }
        /**
         * String tokenize
         */
        public List<Token> Tokenization(string[] arrToken)
        {
            checkNull(arrToken);
            var regex = new Regex(TITLE_CONTENT_REGEX);
            
            for(int i = 0; i < arrToken.Length;i++)
            {
                Console.WriteLine("token:"+arrToken[i]);
                if (false) {
                    tokenList.Add(new TitleKeyword(arrToken[i]));
                }
                else if (regex.Match(arrToken[i]).Success)
                {
                    // title level에 따른 데이터
                    tokenList.Add(new Title(arrToken[i], checkLevel(arrToken[i])));
                }
                else if (Regex.Match(arrToken[i],BOLD_CONTENT).Success)
                {
                    tokenList.Add(new Bold(arrToken[i]));
                }
                else if (Regex.Match(arrToken[i], LIST_REGEX_STRING).Success)
                {
                    tokenList.Add(new AsciiList(arrToken[i]));
                }
                else if (false)
                {
                    // 여긴 code block 들어갈 자리
                }
                else if (Regex.Match(arrToken[i],INLINECODE_REGEX_STRING).Success)
                {
                    tokenList.Add(new InlineCode(arrToken[i]));
                }
                else if (Regex.Match(arrToken[i],TABLE_REGEX_STRING).Success)
                {
                    Console.WriteLine("table content");
                    // 여기서 해야하나?
                    StringBuilder sb = new StringBuilder();
                    i += 1;
                    while (!Regex.Match(arrToken[i], TABLE_REGEX_STRING).Success)
                    {
                        if (!string.IsNullOrEmpty(arrToken[i]))
                        {
                            Console.WriteLine("if 문 안으로 들어옴");
                            sb.Append(arrToken[i]).Append("\n");
                            Console.WriteLine("append");
                            i += 1;
                        }

                    }
                    tokenList.Add(new Table(sb.ToString()));
                }
                else if(!"".Equals(arrToken[i]))
                {
                    // 굵기, 기울임, 코드, 고정폭은 content에서 해야할 듯
                    Console.WriteLine("content 구문 ");
                    tokenList.Add(new Content(arrToken[i]));
                }
            }

            return tokenList;

        }

        private void StoreTable()
        {
            
        }

        private  void checkNull(Object o)
        {
            if(o == null)
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        /**
         * 굵은 글씨인지 확인
         * **test**
         * ***test***
         * 이렇게 해도 굵은 체이므로 갯수가 동일한지 확인 해봐야 할듯
         * 우선은 굵기에 해당하는 파악
         */
        private string checkBold(String str)
        {
            return "";
        }

        private string checkLevel(string str)
        {
            Regex regex = new Regex("=|\\*|\\.|\\-");
            return regex.Matches(str, 0).Count.ToString();
        }
    }

}
