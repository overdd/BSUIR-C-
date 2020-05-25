using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_6
{
    class LibreOfficeWriterVersionComparer : IComparer<LibreOfficeWriter>
    {
        public int Compare(LibreOfficeWriter x, LibreOfficeWriter y)
        {
            return x.Version.CompareTo(y.Version);
        }

    }
}
