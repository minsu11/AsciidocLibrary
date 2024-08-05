using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    public class GrammarVisitorComponent : GrammarVisitor
    {
        private string[] titleKeywordArr = new[] { "hardbreaks" };
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
            return "<img";
        }
        
        public string visit(Title title)
        {
            return "<h" + title.GetTitleLevel() + ">" + title.GetContent() + "/<h" + title.GetTitleLevel() + ">";
        }

        
        public string visit(Table table)
        {
            throw new NotImplementedException();
        }

        public string visit(Italic italic)
        {
            throw new NotImplementedException();
        }

        public string visit(Monospace monospace)
        {
            throw new NotImplementedException();
        }

        public string visit(Bold bold)
        {
            throw new NotImplementedException();
        }

        public string visit(IncludeFile includeFile)
        {
            throw new NotImplementedException();
        }

        public string visit(NewLine newLine)
        {
            throw new NotImplementedException();
        }

        public string visit(Content content)
        {
            return "<p>" + content.GetContent() + "</p>";
        }
    }
}
