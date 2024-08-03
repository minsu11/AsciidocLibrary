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
            string[] parserStr = content.Split("\n"); // \n으로 문단 구분

            return "";
        }

        public static string Process(string content)
        {
            return ContentProcess(content);
        }
        


        
    }
}
