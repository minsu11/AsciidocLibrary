using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;
//문단(Paragraphs) 메서드


/* 줄바꿈(Line Break) 메서드
 * 뒤에 +가 붙거나 [%hardbreaks] 
 * 문서 전체에 줄바꿈 속성:
 * = Test 제목
 * :hardbreaks:
*/

/*
 * Level 0 제목에 속성이 붙는지 확인 메서드
 * 속성
 * hardbreaks, 
 * sectnums, 
 * toc, 
 * toclevels, 
 * toc-title, 
 * description
 * keywords, 
 * imagesdir
 */


/*
 * 다음 문단이 read line인지 확인하는 메서드
 */
namespace AsciidocLibrary
{
    internal interface Grammar
    {
        public String accept(Token token);
    }
}
