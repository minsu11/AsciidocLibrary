// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using AsciidocLibrary;

public class Program
{
    
    // table, content, title, list, 
    private static string Mono_Regex = "(`{1,2})[\\wㄱ-ㅎ가-힣]*\\1";
    
    static void Main(string[] args)
    {
        string TableStr =
            "|===\n| Column 1 \n| Column 2 \n| Column 3\n| Data 1   | Data 2   | Data 3\n| 2 rows merged |^| Merged Cell\n| Data 4   | Data 5   | Data 6\n|===";
        string[] TableArr = TableStr.Split("|");
        Console.WriteLine("Table Arr" + TableArr.Length);
        foreach (var VARIABLE in TableArr)
        {
            Console.WriteLine(VARIABLE);
        }
            
        
        
        Regex MonoRegex = new Regex(Mono_Regex);
        string input12 = "ㅁㄴㄹㅁㄴㅇ ``asd`` ㅁㅇㄴㅇㅁㄴ\n";
        
        if (MonoRegex.Match(input12).Success)
        {
            Console.WriteLine(MonoRegex.Match(input12).ToString());
            Console.WriteLine("조건 확인");
        }
        
        
        string example3 = "_apple_ dasd dasdsa _*asdf*_ _asfas_";
        string[] arrex = Regex.Split(example3,"[_]+[^ ]+[_]+");
        MatchCollection mat = Regex.Matches(example3,"[_]+[^ ]+[_]+");
        Console.WriteLine(mat[1].ToString());
        Console.WriteLine(arrex.Length);
        foreach (var VARIABLE in arrex)
        {
            Console.WriteLine(VARIABLE);
        }
        
        
        string pattern = @"(\*+)([^\* ]+)(\*+)";
        string replacement = "<br>$2</br>";
        Regex r1 = new Regex(pattern);
        string input = "**asd** **asdf**";
        string input2 = "***asd** ***dsa**";
        string[] input3 = input2.Split(" ");
        string example =
            "= 문서 제목\nAuthor Name <author@example.com>\n\n\n\n\n\n\nv1.0, 2024-07-30\n\n:toc: macro\n:toc-title: 목차\n:toclevels: 2\n:sectnums:\n:imagesdir: ./images\n:source-highlighter: highlightjs\n:strong: *\n\n\n\n\n\n\n\n[.bold]#Bold Text#\n\n\n\n\n\n\n== 1단계 제목\n\n이것은 간단한 문단입니다. AsciiDoc은 다양한 텍스트 스타일을 지원합니다. *굵게*, _기울임_, `코드`, 그리고 `+dsa 고정 폭      텍스트+` 등이 가능합니다.\n\n\nHello, NHN Academy.\n[%hardbreak]\nThis is a second line with a hard break.\n[%hardbreak]\nThis line should be separated by a break tag.\n\n\n\n\n[NOTE]\n====\n이것은 주의 상자입니다.\n====\n\n[TIP]\n====\ndsa\n====\n\n== 목록과 표\n\n=== 불릿 목록\n\n\n* 첫 번째 항목\n\n* 두 번째 항목\n* 세 번째 항목\n- dsa\n* dsa\n\n=== 번호 목록\n\n. 첫 번째 항목\n.. 첫 번째 항목의 하위 항목\n. 두 번째 항목\n\n- ㅇㄴㅁ\n\n=== 정의 목록\n\nAPI:: Application Programming Interface\nHTTP:: HyperText Transfer Protocol\n\n=== 테이블\n\n[cols=\"3,7\"]\n|===\n| 항목 | 설명\n\n| 항목 1\n| 첫 번째 항목의 설명\n\n| 항목 2\n| 두 번째 항목의 설명\n\n|항목3\n|ㅇㄴㅁㅇ\n|=== \n\n.세로 병합\n[cols=\"3*\"]\n|===\n| Column 1 | Column 2 | Column 3\n| Data 1   | Data 2   | Data 3\n| 2 rows merged |^| Merged Cell\n| Data 4   | Data 5   | Data 6\n|===\n\n\n\n\n== 코드 블록\n\n[source, python]\n----\ndef hello_world():\n    print(\"Hello, World!\")\n----\n\n== 이미지와 링크\n\n이미지 삽입 예제:\n\nimage::logo.png[로고 이미지]\n\n링크 삽입 예제:\n\n링크를 여기에 추가하세요: https://asciidoctor.org[AsciiDoctor 홈페이지]\n\n== 블록 요소\n\n=== 인용문\n\n[quote, Albert Einstein]\n____\nImagination is more important than knowledge.\n____\n\n=== 소스 코드 블록\n\n[source, java]\n----\npublic class HelloWorld {\n    public static void main(String[] args) {\n        System.out.println(\"Hello, World!\");\n    }\n}\n----\n\n=== 리터럴 블록\n\n....\n이 텍스트는 리터럴 블록 안에 있습니다.\n줄 바꿈과 공백이 그대로 유지됩니다.\n....\n\n=== 사이드바\n\n[sidebar]\n사이드바 텍스트입니다.\n\n\n== 각주\n\n각주 예제입니다.footnote:[이것은 각주입니다.]\n\n== 매크로\n\n목차를 여기 넣습니다:\n\ntoc::[]\n\n== 수식\n\nlatexmath:[e^{i\\pi} + 1 = 0]\n\n== 매개변수화된 텍스트\n\n:customer: John Doe\n\nDear {customer},\n\n이 텍스트는 매개변수화되었습니다.\n\n== 주석\n\n// 이 줄은 주석입니다.\n\n== 사용자 정의 스타일\n\n[.custom]\n커스텀 스타일의 텍스트입니다.\n\n== 앵커와 교차 참조\n\n[[target]]\n이것은 교차 참조의 대상입니다.\n\n다음 섹션을 참조하세요: <<target, 교차 참조 대상>>\n";
        // Console.WriteLine(r1.Replace(input,replacement));
        string ex = Regex.Replace(example, "([^\\wㄱ-ㅎ가-힣.?!,= \"\\[\\]\\-():;}{><]+[\\n]{1})[\\n]+", "\n");
        string[] exampleArr = Regex.Replace(example,"([^\\wㄱ-ㅎ가-힣.?!,= \"\\[\\]\\-():;}{><]+[\\n]{1})[\\n]+","\n").Split("\n");
        
        Console.WriteLine("=======");
        Console.WriteLine(ex);
        Console.WriteLine("-=======");
        
        foreach (var VARIABLE in exampleArr)
        {
           
            Console.WriteLine(VARIABLE);
        }
        
        if(r1.Match(input2).Groups[3].Length>r1.Match(input2).Groups[5].Length)
        {
            Match m = r1.Match(input2);
            Console.WriteLine(m.ToString()); 
            Console.WriteLine(m.Groups.Count);
            Console.WriteLine(r1.Replace(input2,"<br>*$2</br>"));
 
        }
        
        string str3 = "test **apple***         dsa.";
        

        Regex regex = new Regex("[\\*]+(.*?)[\\*]+");
            
        str3 = regex.Replace(str3, "<b>$1</b>");
        Console.WriteLine(str3);
        string str1 =
            "= 문서 제목\nAuthor Name <author@example.com>\nv1.0, 2024-07-30\n\n:toc: macro\n:toc-title: 목차\n:sectnums:\n:imagesdir: ./images\n:source-highlighter: highlightjs\n\n\n== 1단계 제목\n\n이것은 간단한 문단입니다. AsciiDoc은 다양한 텍스트 스타일을 지원합니다. *굵게*, _기울임_, `코드`, 그리고 `+dsa 고정 폭    텍스트+` 등이 가능합니다.\n\nHello, NHN Academy.\n[%hardbreak]\nThis is a second line with a hard break.\n[%hardbreak]\nThis line should be separated by a break tag.\n\n\n\n\n[NOTE]\n====\n이것은 주의 상자입니다.\n====\n\n[TIP]\n====\ndsa\n====\n\n== 목록과 표\n\n=== 불릿 목록\n\n\n\n* 첫 번째 항목\n\n* 두 번째 항목\n* 세 번째 항목\n\n\n\n=== 번호 목록\n\n[%hardbreaks]\ndsada\ndsadas\n\ndsada\ndsa\n\n. 첫 번째 항목\n.. 첫 번째 항목의 하위 항목\n. 두 번째 항목"; 
        
        string str = ParserProcess.Process(str3);
        string str2 = "|===\n|가나다|나다라\n|asdf|asfas\n|===\n";
        string resultStr = ParserProcess.Process(str2);
        Console.WriteLine(resultStr);

        
        
    }
}