using System;
using System.Collections.Generic;
using System.Text;

namespace AsciidocLibrary
{
    internal interface Grammar
    {
        string convertTitle(string content); // =,==, === 등

        string convertBold(string content);
    }
}
