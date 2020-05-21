using System;
using System.Text;

namespace Laba_1_5
{
    abstract class TextProcessor : Software, IComparable
    {
        public abstract string[] SupportedFormats { get; set; }
        public override string SourceCode { get; set; }

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
                //Console.Write(" " + element + " | ");
                stringBuilder.Append(element + " ");
            }
           // Console.WriteLine();
            return stringBuilder.ToString();
        }

        public int CompareTo(object obj)
        {
            return this.SupportedFormats.Length.CompareTo(((TextProcessor)obj).SupportedFormats.Length);
        }

        protected TextProcessor() : base()
        {
            SupportedFormats = null;
            SourceCode = "";
        }
    }
}
