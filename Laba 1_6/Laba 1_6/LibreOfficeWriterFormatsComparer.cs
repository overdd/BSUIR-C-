using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Laba_1_6
{
    class LibreOfficeWriterFormatsComparer : IComparer<LibreOfficeWriter>
    {
        public int Compare(LibreOfficeWriter x, LibreOfficeWriter y)
        {
            return x.SupportedFormats.Length.CompareTo(y.SupportedFormats.Length);
        }

    }
}
