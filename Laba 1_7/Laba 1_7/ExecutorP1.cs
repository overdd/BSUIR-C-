using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laba_1_7
{   
    [Serializable]
    class ExecutorP1
    {
        public static void getDiskFolder()
        {
            Console.WriteLine("Current directory is " + Directory.GetCurrentDirectory());
        }
        public static void getNumeratedListFolders()
        {
            string[] folders = Directory.GetDirectories(Directory.GetCurrentDirectory());
            for (int i = 1; i < folders.Length+1; i++) {
                Console.WriteLine(i + ". " + folders[i - 1]);
            }
        }
        public static void getNumeratedListFiles()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            for (int i = 1; i < files.Length+1; i++)
            {
                Console.WriteLine(i + ". " + files[i - 1]);
            }
        }
        public static void getFileContent()
        {
            int i = inputInt("Enter number of file to be read");
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            StreamReader streamReader = new StreamReader(files[i-1]);
            String str;
            while ((str = streamReader.ReadLine()) != null) {
                Console.WriteLine(streamReader.ReadLine());
            }
        }
        public static void createNewDirectory()
        {
            String path = Directory.GetCurrentDirectory() + @"/" + inputString("Enter name for a new folder!");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            else {
                Console.WriteLine("Sorry, the folders already exists!");
            }
        }
        public static void deleteEmptyFolder()
        {
            try
            {
                int i = inputInt("Enter number of folder to be deleted");
                string[] folders = Directory.GetDirectories(Directory.GetCurrentDirectory());
                string path = folders[i - 1];
                if (Directory.GetDirectories(path).Length + Directory.GetFiles(path).Length < 1)
                {
                    Directory.Delete(path);
                }
                else
                {
                    Console.WriteLine("Folder doesn't exists or folder is not empty!");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public static void deleteFileByNumber()
        {
            try
            {
                int i = inputInt("Enter number of file to be deleted");
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                string path = files[i - 1];
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }
                else
                {
                    Console.WriteLine("File doesn't exists!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void getFileListByDate()
        {
            try
            {
                string date = inputString("Enter date like 01.01.2000");
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                foreach (string s in files)
                {
                    FileInfo fileInfo = new FileInfo(s);
                    if (fileInfo.CreationTime.Date == Convert.ToDateTime(date))
                        Console.WriteLine(fileInfo.Name);
                }
                string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
                foreach (string d in directories) {
                    files = Directory.GetFiles(d);
                    foreach (string s in files)
                    {
                        FileInfo fileInfo = new FileInfo(s);
                        if (fileInfo.CreationTime.Date == Convert.ToDateTime(date))
                            Console.WriteLine(fileInfo.Name);
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void getFilesWithText()
        {
            try
            {
                string text = inputString("Entere text for searching");
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                foreach (string f in files)
                {
                    int substrIndex = new StreamReader(f).ReadToEnd().IndexOf(text);
                    if (substrIndex != -1) {
                        Console.WriteLine(new FileInfo(f).Name);
                    } 
                }
                   string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
                foreach (string d in directories)
                {
                    files = Directory.GetFiles(d);
                    foreach (string f in files)
                    {
                        int substrIndex = new StreamReader(f).ReadToEnd().IndexOf(text);
                        if (substrIndex != -1)
                        {
                            Console.WriteLine(new FileInfo(f).Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int inputInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string inputString(string message)
        {
            Console.WriteLine(message);
            return Convert.ToString(Console.ReadLine());
        }
    }
}
