using System;

namespace Laba_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("*     Главное меню         *");
                Console.WriteLine("****************************");
                Console.WriteLine("1 – устанавливает текущий диск/каталог");
                Console.WriteLine("2 – выводит список всех каталогов в текущем (пронумерованный)");
                Console.WriteLine("3 – выводит список всех файлов в текущем каталоге (пронумерованнный)");
                Console.WriteLine("4 – выводит на экран содержимое указанного файла (по номеру)");
                Console.WriteLine("5 – создает каталог в текущем");
                Console.WriteLine("6 – удаляет каталог по номеру, если он пустой");
                Console.WriteLine("7 – удаляет файлы с указанными номерами");
                Console.WriteLine("8 – выводит список всех файлов с указанной датой создания (ищет в текущем каталоге и подкаталогах)");
                Console.WriteLine("9 –  выводит список всех текстовых файлов, в которых содержится указанный текст (ищет в текущем каталоге и подкаталогах)");
                Console.WriteLine("21 – Добавьте статический метод, который запишет в текстовый файл всю информацию о типе вашего класса (рефлексия). Имя файла – параметр метода.");
                Console.WriteLine("22 – Добавьте экземплярный метод, который будет сохранять в бинарный файл всю информацию о текущем объекте.Имя файла – параметр метода.");
                Console.WriteLine("23 – Метод, который будет читать информацию из бинарного файла и возвращать готовый объект. Имя файла – параметр метода.");
                Console.WriteLine("31 – ввод строки с клавиатуры (указывать размер)");
                Console.WriteLine("32 – вывод строки");
                Console.WriteLine("33 – после указанного символа каждый раз вставить *");
                Console.WriteLine("34 – заменить один символ на другой");
                Console.WriteLine("35 – удалить все вхождения указанной подстроки");

                Console.WriteLine("0 – выход");
                int otvet = Convert.ToInt32(Console.ReadLine());
                switch (otvet)
                {
                    case 1: ExecutorP1.getDiskFolder(); break;
                    case 2: ExecutorP1.getNumeratedListFolders(); break;
                    case 3: ExecutorP1.getNumeratedListFiles(); break;
                    case 4: ExecutorP1.getFileContent(); break;
                    case 5: ExecutorP1.createNewDirectory(); break;
                    case 6: ExecutorP1.deleteEmptyFolder(); break;
                    case 7: ExecutorP1.deleteFileByNumber(); break;
                    case 8: ExecutorP1.getFileListByDate(); break;
                    case 9: ExecutorP1.getFilesWithText(); break;
                    case 21: ExecutorP2.getTypeInfo("TypeInfoGetter.txt"); break;
                    case 22: new ExecutorP2().writeBinaryObjectCopy("BinaryInstanceData.bin"); break;
                    case 23: new ExecutorP2().readBinaryObjectCopy("BinaryInstanceData.bin"); break;
                    case 31: ExecutorP3.enterStringBuider(); break;
                    case 32: ExecutorP3.writeStringBuilderToConsole(); break;
                    case 33: ExecutorP3.insertStarAfterSymbol(); break;
                    case 34: ExecutorP3.replaceSymbols(); break;
                    case 35: ExecutorP3.deleteSymbols(); break;

                    default: return;
                }
            }
        }


    }
}

