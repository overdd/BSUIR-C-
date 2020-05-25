using System;
using System.Collections;

namespace Laba_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileFormatsWord = { "doc", "rtf" };
            string[] fileFormatsWord98 = { "doc", "rtf", "pdf" };
            string[] fileFormatsWord2007 = { "doc", "docx", "rtf", "pdf" };
            ArrayList collection = new ArrayList();
            collection.Add(new MicrosoftWord98(fileFormatsWord));
            collection.Add(new MicrosoftWord98(fileFormatsWord));
            collection.Add(new MicrosoftWord98(fileFormatsWord2007));
            collection.Add(new MicrosoftWord(fileFormatsWord));
            collection.Add(new LibreOfficeWriter(fileFormatsWord98, 7.1));
            collection.Add(new LibreOfficeWriter(fileFormatsWord2007, 6.0));
            collection.Add(new LibreOfficeWriter(fileFormatsWord, 8.1));

            while (true)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("*     Главное меню         *");
                Console.WriteLine("****************************");
                Console.WriteLine("1 – просмотр коллекции");
                Console.WriteLine("2 – добавление элемента (данные вводим с клавиатуры)");
                Console.WriteLine("3 – добавление элемента по указанному индексу (индекс и данные вводим с клавиатуры)");
                Console.WriteLine("4 – нахождение элемента с начала коллекции (данные для поиска по полю name вводим с клавиатуры, минимум 2 объекта с одинаковыми именами)");
                Console.WriteLine("5 – нахождение элемента с конца коллекции (данные для поиска по полю name вводим с клавиатуры, минимум 2 объекта с одинаковыми именами)");
                Console.WriteLine("6 – удаление элемента по индексу (индекс вводим с клавиатуры)");
                Console.WriteLine("7 – удаление элемента по значению (данные для поиска по полю name вводим с клавиатуры)");
                Console.WriteLine("8 – реверс коллекции");
                Console.WriteLine("9 – сортировка");
                Console.WriteLine("10 –  выполнение методов всех объектов, поддерживающих Multipliable");
                Console.WriteLine("0 – выход");
                int otvet = Convert.ToInt32(Console.ReadLine());
                switch (otvet)
                {
                    case 1: Executor.collectionViewer(collection); break;
                    case 2: Executor.addElementToCollection(collection); break;  //вводим с клавиатуры форматы
                    case 3: Executor.addElementToCollectionByIndex(collection); break; // вводим с клавиатуры форматы
                    case 4: Executor.findFirstMatch(collection); break;  // ищем по полю SourceCode 
                    case 5: Executor.findLastMatch(collection); break;  // ищем по полю SourceCode с конца 
                    case 6: Executor.removeByIndex(collection); break;  // удаляем элемент с заданным индексом
                    case 7: Executor.removeByMatch(collection); break;  // удаляем элемент при совпадении строки поиска
                    case 8: Executor.reverseCollection(collection); break;
                    case 9: Executor.sortCollection(collection); break; // сортируем по полю SourceCode
                    case 10: Executor.runMultipliableInterface(collection); break; // запускаем метод Mult() у экземпляров классов, которые реализуют Multipliable
                    default: return;
                }
            }
        }
    }
}
