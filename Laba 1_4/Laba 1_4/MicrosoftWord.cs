using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_4
{
    class MicrosoftWord : TextProcessor
    {
        public override string[] SupportedFormats { get; set; }

        public override void convertToPDF()
        {
            Console.WriteLine("File is converted to PDF in Microsoft Word");
        }

        new public void saveFile()
        {
            base.saveFile();
            Console.WriteLine("The file is saved with Microsoft Office!");
        }

        public void createMacros()
        {
            Console.WriteLine("The macros has been added to Microsoft Word document!");
        }

        public MicrosoftWord(string[] supportedFormats)
        {
            SupportedFormats = supportedFormats;
        }
    }
}
