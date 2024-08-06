using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * ascii doc 문법
     * image::example.png[Example Image, 200, 100, link="http://example.com]
     *
     * html 변환
     * <a href="http://example.com">
     *      <img src="example.png" alt="Example Image" width="200" height="100">
     * </a>
     */
    public class Image : Token
    {
        private static string DefaultPath;
        private string imageTitle;
        private string link;
        private string width;
        private string height;
        
        
        public Image(string imageUrl) : base(imageUrl) { 
        }

        public override string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }

        public static void settingDefaultDir(string dir)
        {
            DefaultPath = dir;
        }
    }
}
