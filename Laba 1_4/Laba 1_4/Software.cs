using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_4
{
    abstract class Software
    {
        private int fileSize;
        public abstract string SourceCode { get; set; }

        public abstract void saveFile();
        public abstract void openFile();
        public void createNewFile(String fileName, String path)
        {
            Console.WriteLine("File {0} in {1} was created!", fileName, path);
        }
        public void maximizeWindow()
        {
            Console.WriteLine("Window is maximized!");
        }
        public void minimizeWindow()
        {
            Console.WriteLine("Window is minimized!");
        }

        protected Software()
        {
            this.fileSize = 0;
            SourceCode = "";
        }
    }
}
