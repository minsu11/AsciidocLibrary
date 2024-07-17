﻿using System;
using System.Collections.Generic;
using System.Text;
using AsciidocLibrary.asciidoctoken;

namespace AsciidocLibrary.grammar
{
    internal interface GrammarVisitor
    {
        void visit(Keyword keywordToken);
        void visit(TitleKeyword titleKeywordToken);

    }
}