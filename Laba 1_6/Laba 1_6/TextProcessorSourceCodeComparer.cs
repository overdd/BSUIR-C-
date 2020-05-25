using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_6
{
    class TextProcessorSourceCodeComparer : IComparer<TextProcessor>
    {
        public int Compare(TextProcessor x, TextProcessor y)
        {
            return x.SourceCode.CompareTo(y.SourceCode);
        }
    }
}
