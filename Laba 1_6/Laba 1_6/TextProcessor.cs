using System;
using System.Text;

namespace Laba_1_6
{
    abstract class TextProcessor : Software, IComparable
    {
        public abstract string[] SupportedFormats { get; set; }

        public string SourceCode { get; set; }


        public override void openFile()
        {
            Console.WriteLine("The file is opened with TextProcessor!");
        }

        public override void saveFile()
        {
            Console.WriteLine("The file is saved with TextProcessor!");
        }

        public virtual void convertToPDF()
        {
            Console.WriteLine("File is converted to PDF");
        }

        public string printSupportedFormats()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string element in SupportedFormats)
            {
                stringBuilder.Append(element + " ");
            }
            return stringBuilder.ToString();
        }

        public new void print() {
            Console.WriteLine("This is " + this.GetType() + " and it supports files: " + this.printSupportedFormats()+ " and SourceCode is " + this.SourceCode);
        } 

        public int CompareTo(object obj)
        {
            return this.SourceCode.CompareTo(((TextProcessor)obj).SourceCode);
        }

        protected TextProcessor() : base()
        {
            SupportedFormats = null;
            this.SourceCode = "";
        }
    }
}
