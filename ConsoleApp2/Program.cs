// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using AsciidocLibrary;

public class Program
{
    static void Main(string[] args)
    {
        
        string str2 = "= dsa\n\n test *apple*.dsa das.";
        string str3 = "test *apple*         dsa.";
        foreach (var s in str3.Split("[^\\wㄱ-ㅎㅏ-ㅣ가-힣\\*]*"))
        {
            Console.WriteLine(s);
        }

        Regex regex = new Regex("\\*(.*?)\\*");
            
        str3 = regex.Replace(str3, "<b>$1</b>");
        Console.WriteLine(str3);
        string str1 =
            "= 문서 제목\nAuthor Name <author@example.com>\nv1.0, 2024-07-30\n\n:toc: macro\n:toc-title: 목차\n:sectnums:\n:imagesdir: ./images\n:source-highlighter: highlightjs\n\n\n== 1단계 제목\n\n이것은 간단한 문단입니다. AsciiDoc은 다양한 텍스트 스타일을 지원합니다. *굵게*, _기울임_, `코드`, 그리고 `+dsa 고정 폭    텍스트+` 등이 가능합니다.\n\nHello, NHN Academy.\n[%hardbreak]\nThis is a second line with a hard break.\n[%hardbreak]\nThis line should be separated by a break tag.\n\n\n\n\n[NOTE]\n====\n이것은 주의 상자입니다.\n====\n\n[TIP]\n====\ndsa\n====\n\n== 목록과 표\n\n=== 불릿 목록\n\n\n\n* 첫 번째 항목\n\n* 두 번째 항목\n* 세 번째 항목\n\n\n\n=== 번호 목록\n\n[%hardbreaks]\ndsada\ndsadas\n\ndsada\ndsa\n\n. 첫 번째 항목\n.. 첫 번째 항목의 하위 항목\n. 두 번째 항목"; 

        string str = ParserProcess.Process(str2);

        Console.WriteLine(str);
    }
}