using System;

namespace Laba_1_5
{
    sealed class LibreOfficeWriter : TextProcessor, Multipliable
    {
        public double Version { get; set; }
        public override string[] SupportedFormats { get; set; }

        public override void openFile()
        {
            Console.WriteLine("The file is opened with LibreOfficeWriter!");
        }

        public void createMacros()
        {
            Console.WriteLine("The macros has been added to LibreOffice Writer document!");
        }

        public void Mult()
        {
        }

        public new void print()
        {
            Console.WriteLine("I'm LibreOffice Writer of {0} version and support these formats: {1}", Version, this.printSupportedFormats());
        }

        public LibreOfficeWriter(string[] supportedFormats, double version)
        {
            SupportedFormats = supportedFormats;
            Version = version;
        }
    }
}
