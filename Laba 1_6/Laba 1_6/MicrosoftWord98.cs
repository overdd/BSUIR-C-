using System;

namespace Laba_1_6
{
    internal class MicrosoftWord98 : MicrosoftWord, Printable
    {
        public new void print()
        {
            Console.WriteLine("File is printed in Microsoft Word 98");
        }

        public void printDocument() {
            ((Printable)this).print();
        }

        void Printable.print() {
            Console.WriteLine("File is printed in Microsoft Word 98 with document printer");
        }

        public new int CompareTo(object obj)
        {
            return this.SupportedFormats.Length.CompareTo(((TextProcessor) obj).SupportedFormats.Length) ;
        }

        public override bool Equals(object obj)
        {
            return obj is MicrosoftWord98 word &&
                   base.Equals(obj) &&
                   SourceCode == word.SourceCode;
        }

        public MicrosoftWord98(string[] supportedFormats):base(supportedFormats)
        {
            this.SourceCode = "Word98";
        }
    }
}
