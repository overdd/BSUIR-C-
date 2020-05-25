using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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

            List<TextProcessor> collectionList = new List<TextProcessor>();
            collectionList.Add(new MicrosoftWord98(fileFormatsWord));
            collectionList.Add(new MicrosoftWord98(fileFormatsWord));
            collectionList.Add(new MicrosoftWord98(fileFormatsWord2007));
            collectionList.Add(new MicrosoftWord(fileFormatsWord));
            collectionList.Add(new LibreOfficeWriter(fileFormatsWord98, 7.1));
            collectionList.Add(new LibreOfficeWriter(fileFormatsWord2007, 6.0));
            collectionList.Add(new LibreOfficeWriter(fileFormatsWord, 8.1));

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
                Console.WriteLine("10 – выполнение методов всех объектов, поддерживающих Multipliable");
                Console.WriteLine("11 – List: просмотр коллекции");
                Console.WriteLine("12 – List: добавление элемента (данные вводим с клавиатуры)");
                Console.WriteLine("13 – List: добавление элемента по указанному индексу (индекс и данные вводим с клавиатуры)");
                Console.WriteLine("14 – List: нахождение элемента с начала коллекции (данные для поиска по полю name вводим с клавиатуры, минимум 2 объекта с одинаковыми именами)");
                Console.WriteLine("15 – List: нахождение элемента с конца коллекции (данные для поиска по полю name вводим с клавиатуры, минимум 2 объекта с одинаковыми именами)");
                Console.WriteLine("16 – List: удаление элемента по индексу (индекс вводим с клавиатуры)");
                Console.WriteLine("17 – List: удаление элемента по значению (данные для поиска по полю name вводим с клавиатуры)");
                Console.WriteLine("18 – List: реверс коллекции");
                Console.WriteLine("19 – List: сортировка");
                Console.WriteLine("20 – List: выполнение методов всех объектов, поддерживающих Multipliable");
                Console.WriteLine("21 – Создайте обобщенный метод, который получает массив произвольного типа и возвращает количество элементов, не равных null.");
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
                    case 11: ListExecutor.collectionViewer(collectionList); break;
                    case 12: ListExecutor.addElementToCollection(collectionList); break;  //вводим с клавиатуры форматы
                    case 13: ListExecutor.addElementToCollectionByIndex(collectionList); break; // вводим с клавиатуры форматы
                    case 14: ListExecutor.findFirstMatch(collectionList); break;  // ищем по полю SourceCode 
                    case 15: ListExecutor.findLastMatch(collectionList); break;  // ищем по полю SourceCode с конца 
                    case 16: ListExecutor.removeByIndex(collectionList); break;  // удаляем элемент с заданным индексом
                    case 17: ListExecutor.removeByMatch(collectionList); break;  // удаляем элемент при совпадении строки поиска
                    case 18: ListExecutor.reverseCollection(collectionList); break;
                    case 19: ListExecutor.sortCollection(collectionList); break; // сортируем по полю SourceCode
                    case 20: ListExecutor.runMultipliableInterface(collectionList); break; // запускаем метод Mult() у экземпляров классов, которые реализуют Multipliable
                    case 21: Console.WriteLine(elementCounter(fileFormatsWord2007)); break;
                    default: return;
                }
            }
        }

        public static int elementCounter<T>(T[] inputArray) {
            int counter =0;
            for (int i = 0; i < inputArray.Length; i++) {
                if (inputArray[i] != null)
                    counter++;
            }
            return counter;
        }
    }
}
