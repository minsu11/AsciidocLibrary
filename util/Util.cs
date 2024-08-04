using AsciidocLibrary.asciidoctoken;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;

namespace AsciidocLibrary
{
    internal class Util
    {
        private static readonly string TITLE_CONTENT_REGEX = "^[={1,6}] [\\wㄱ-ㅎㅏ-ㅣ가-힣]+$";
        private static readonly string BOLD_CONTENT = "**";
        private static LinkedList<Token> tokenList;

        public Util() { 
            
        }
        /**
         * String tokenize
         */
        public LinkedList<Token> Tokenization(string[] arrToken)
        {
            checkNull(arrToken);
            Regex regex = new Regex().
            for(int i = 0; i < arrToken.Length;i++)
            {
                if (TITLE_CONTENT.Equals(arrToken[i])) {
                    tokenList.AddLast(new TitleKeyword(arrToken[i]));
                }
                else if (BOLD_CONTENT.Equals(arrToken[i].Substring(0, 2)))
                {
                    
                    tokenList.AddLast(new Bold(arrToken[i]));
                }
                else
                {
                    tokenList.AddLast(new Content(arrToken[i]));
                }
            }

            return tokenList;

        }

        private  void checkNull(Object o)
        {
            if(o == null)
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private string checkBold(String str)
        {
            return "";
        }

        private string checkTitleLevel(string str)
        {
            Regex regex = new Regex(TITLE_CONTENT);
            return regex.Matches(str, 0).Count.ToString();
        }
    }

}
