using System.Collections.Generic;

namespace AsciidocLibrary
{
    public enum RegexExpression
    {
        TitleContentRegex,
        BoldContent,
        KeywordRegex,
        TitleKeywordRegex
    }
    
    public static class TokenRegex
    {
        private static readonly Dictionary<RegexExpression, string> RegexDict = new Dictionary<RegexExpression, string>
        {
            {RegexExpression.TitleContentRegex  , "[={1,6}] [\\wㄱ-ㅎㅏ-ㅣ가-힣]*"},
            {RegexExpression.BoldContent, "[\\*][\\w]+[\\*][^\\wㄱ-ㅎㅏ-ㅣ가-힣]*"},
            { RegexExpression.KeywordRegex ,"[\\[]{1}[\\wㄱ-ㅎㅏ-ㅣ가-힣]*[\\]]{1}"},
            {RegexExpression.TitleKeywordRegex, "[\\:]{1}[\\wㄱ-ㅎㅏ-ㅣ가-힣]*[\\:]{1}"}
        };

        public static string GetRegex(RegexExpression regexExpression)
        {
            return RegexDict[regexExpression];
        }
    }
}