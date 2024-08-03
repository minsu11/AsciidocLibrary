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
            return "<!DOCTYPE html>"
                    + "<html lang=\"ko\">"
                    + "<head>"
                    + "<meta charset=\"UTF-8\">"
                    + "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">"
                    + "<title>" + headTitle + "</title>"
                    + headContent 
                    + "</head>"
                    + "<body>"
                    + content
                    + "</body>"
                    + "</html>";
        }
        public static string GetHtmlForm(string content)
        {
            return GetHtmlForm("Title", "", content);
        }
    }
}
