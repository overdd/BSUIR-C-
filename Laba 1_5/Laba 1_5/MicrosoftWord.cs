using System;

namespace Laba_1_5
{
    class MicrosoftWord : TextProcessor, Multipliable, upperCaseable
    {
        public int Version { get; set; }
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

        public void Mult()
        {
        }

        public void Up()
        {
            foreach (string element in SupportedFormats)
            {
                Console.WriteLine(element.ToUpperInvariant());
            }
        }

        public new void print() {
            Console.WriteLine("File is printed in Microsoft Word ");
        }



        public MicrosoftWord(string[] supportedFormats)
        {
            SupportedFormats = supportedFormats;
        }
    }
}
