using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AsciidocLibrary
{
    internal class HtmlForm
    {
       private HtmlForm() { 
        }

        public static string GetHtmlForm(string headTitle, string headContent, string content)
        {
            return "<!DOCTYPE html>\n"
                    + "<html lang=\"ko\">\n"
                    + "<head>\n"
                    + "<meta charset=\"UTF-8\">\n"
                    + "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n"
                    + "<title>\n" + headTitle + "</title>\n"
                    + headContent 
                    + "</head\n>"
                    + "<body>\n"
                    + content
                    + "</body>\n"
                    + "</html>\n";
        }
        public static string GetHtmlForm(string content)
        {
            return GetHtmlForm("Title", "", content);
        }
    }
}
