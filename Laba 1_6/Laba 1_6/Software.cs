﻿using System;

namespace Laba_1_6
{
    public abstract class Software : Printable
    {
        private int fileSize;

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

        public void print()
        {
        }

        protected Software()
        {
            this.fileSize = 0;
            Console.WriteLine("This lane is from constructor of Software class.");
        }
    }
}
