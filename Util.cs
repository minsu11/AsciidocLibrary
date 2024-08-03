using AsciidocLibrary.asciidoctoken;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace AsciidocLibrary
{
    internal class Util
    {
        private static readonly string TITLE_CONTENT = "=";
        private static readonly string BOLE_CONTENT = "**";
        private static LinkedList<Token> tokenList;
        private Util() { 
            
        }
        /**
         * String tokenize
         */
        public Token[] tokenization(string[] arrToken)
        {
            checkNull(arrToken);
            
            for(int i = 0; i < arrToken.Length;i++)
            {
                if (TITLE_CONTENT.Equals(arrToken[i])) {
                    tokenList.AddLast(new TitleKeyword(arrToken[i]));
                }
                else if (BOLE_CONTENT.Equals(arrToken[i].Substring(0, 2)))
                {
                    
                }
            }
            return null;
        }

        private static void checkNull(Object o)
        {
            if(o == null)
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private static string checkBold(String str)
        {

        }
       
    }

}
