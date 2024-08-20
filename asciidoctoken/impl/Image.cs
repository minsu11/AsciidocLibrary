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
        private string link;
        private int  DEFAULT_WIDTH = 200;
        private int DEFAULT_HEIGHT = 100;

        private string IMAGE_TITLE = "";


        public Image(string imageTitle, string imageUrl,string link, string width, int height) : base(imageUrl)
        {
            
        }
        
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
