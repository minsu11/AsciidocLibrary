using AsciidocLibrary.grammar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary.asciidoctoken
{
    /**
     * 예시 코드
     * :hardbreaks:
     * :toc:
     * :toc-title: 목차
     * :sectnums:
     * :imagesdir: ./images
     * :source-highlighter: highlightjs
     * :toc: (Table of Contents):

이 키워드는 문서에 목차를 생성하기 위한 것으로, 보통 HTML에서 <div class="toc"> 형태로 변환되며, <head>에는 영향을 주지 않습니다.
:toc-title::

이 키워드는 목차의 제목을 설정합니다. HTML로 변환될 때 목차 <div> 안에 <h2> 같은 제목 태그로 변환됩니다.
:sectnums: (Section Numbers):

이 키워드는 문서의 섹션 번호를 자동으로 붙이는 기능을 제공합니다. HTML 변환 시, 각 섹션의 제목 앞에 번호를 추가하는 형태로 변환되며, 역시 <head>와는 직접 관련이 없습니다.
:imagesdir::

이 키워드는 이미지 파일이 위치한 디렉터리를 지정합니다. HTML 변환 시, 이미지 태그 (<img>)의 경로 설정에 사용되며, <head>에는 영향을 미치지 않습니다.
:source-highlighter::

이 키워드는 소스 코드의 하이라이팅 스타일을 지정하는 것으로, 변환된 HTML 문서에서 코드 블록에 어떤 하이라이터를 사용할지 설정합니다. 일부 하이라이터는 CSS 또는 JavaScript 파일을 참조하므로, 변환된 HTML의 <head>에 관련된 <link> 또는 <script> 태그가 추가될 수 있습니다.
     */
    //Todo highliter가 들어오면 어떻게 할지 고민 해봐야함
    //Todo 그리고 header에 들어가는 경우도 고민해봐야함
    
    
    internal class TitleKeyword : Token
    {
        public TitleKeyword(string title) : base(title) {
        }
       
        
        public override string Accept(GrammarVisitor grammarVisitor)
        {
            return grammarVisitor.visit(this);
        }
    }
}
