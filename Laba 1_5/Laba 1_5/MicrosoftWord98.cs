using System;

namespace Laba_1_5
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

        public int CompareTo(object obj)
        {
            return this.SupportedFormats.Length.CompareTo(((TextProcessor) obj).SupportedFormats.Length) ;
        }

        public MicrosoftWord98(string[] supportedFormats):base(supportedFormats)
        {
    
        }
    }
}
