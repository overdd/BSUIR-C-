using System;

namespace Laba_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileFormatsWriter = { "doc", "docx", "rtf", "odf" };
            string[] fileFormatsWord = { "doc", "docx", "rtf", "pdf" };
            LibreOfficeWriter libreOfficeWriter = new LibreOfficeWriter(fileFormatsWriter);
            MicrosoftWord microsoftWord = new MicrosoftWord(fileFormatsWord);

            libreOfficeWriter.openFile();
            libreOfficeWriter.createNewFile("doc1.docx", "C://My files");
            libreOfficeWriter.saveFile();
            libreOfficeWriter.maximizeWindow();
            libreOfficeWriter.minimizeWindow();
            libreOfficeWriter.createMacros();
            libreOfficeWriter.convertToPDF();

            microsoftWord.openFile();
            microsoftWord.createNewFile("doc1.docx", "C://My files");
            microsoftWord.saveFile();  // сокрытый метод
            microsoftWord.maximizeWindow();
            microsoftWord.minimizeWindow();
            libreOfficeWriter.createMacros();
            microsoftWord.convertToPDF();

        }
    }
}
