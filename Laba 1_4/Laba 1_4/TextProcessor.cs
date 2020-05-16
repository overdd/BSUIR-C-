using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_4
{
    abstract class TextProcessor : Software
    {
        public abstract string[] SupportedFormats { get; set; }
        public override string SourceCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void openFile()
        {
            Console.WriteLine("The file is opened with TextProcessor!");
        }

        public override void saveFile()
        {
            Console.WriteLine("The file is saved with TextProcessor!");
        }

        public virtual void convertToPDF() {
            Console.WriteLine("File is converted to PDF");
        }

        protected TextProcessor() : base()
        {
            SupportedFormats = null;
            SourceCode = "";
        }
    }
}
