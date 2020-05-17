using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_4
{
    sealed class LibreOfficeWriter : TextProcessor
    {
        public override string[] SupportedFormats { get; set; }

        public override void openFile()
        {
            Console.WriteLine("The file is opened with LibreOfficeWriter!");
        }

        public void createMacros() {
            Console.WriteLine("The macros has been added to LibreOffice Writer document!");
        }

        public LibreOfficeWriter(string[] supportedFormats)
        {
            SupportedFormats = supportedFormats;
        }
    }
}
