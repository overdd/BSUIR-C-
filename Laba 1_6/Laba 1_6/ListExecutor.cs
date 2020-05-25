using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Laba_1_6
{
    public static class ListExecutor
    {
        public static void collectionViewer(List<TextProcessor> collection)
        {
            Console.WriteLine("This collection consists of following elements: ");
            foreach (TextProcessor element in collection)
            {
                element.print();
            }
        }

        public static void addElementToCollection(List<TextProcessor> collection)
        {
            ArrayList newFormatsArray = Helper.readKeysFormats();
            string[] stringMockup = new string[newFormatsArray.Count];
            for (int i = 0; i < newFormatsArray.Count; i++)
            {
                stringMockup[i] = (string)newFormatsArray[i];
            }
            collection.Add(new MicrosoftWord(stringMockup));
        }

        public static void addElementToCollectionByIndex(List<TextProcessor> collection)
        {
            int newElementIndex = Helper.readKeysIndex();
            ArrayList newFormatsArray = Helper.readKeysFormats();
            string[] stringMockup = new string[newFormatsArray.Count];
            for (int i = 0; i < newFormatsArray.Count; i++)
            {
                stringMockup[i] = (string)newFormatsArray[i];
            }
            if (newElementIndex < collection.Count)
                collection.Insert(newElementIndex, new MicrosoftWord(stringMockup));
        }
        public static void findFirstMatch(List<TextProcessor> collection)
        {
            TextProcessor tempObjectMSW = new MicrosoftWord(new string[0]); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            TextProcessor tempObjectMSW98 = new MicrosoftWord98(new string[0]); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            TextProcessor tempObjectLOW = new LibreOfficeWriter(new string[0], 1); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            tempObjectMSW.SourceCode = Helper.readKeysSearchCode();
            tempObjectMSW98.SourceCode = tempObjectMSW.SourceCode;
            tempObjectLOW.SourceCode = tempObjectMSW.SourceCode;
            foreach (TextProcessor element in collection)
            {
                if (tempObjectMSW.Equals(element))
                {
                    Console.WriteLine("Найдено первое сопадение: ");
                    element.print();
                    break;
                }
                if (tempObjectMSW98.Equals(element))
                {
                    Console.WriteLine("Найдено первое сопадение: ");
                    element.print();
                    break;
                }
                if (tempObjectLOW.Equals(element))
                {
                    Console.WriteLine("Найдено первое сопадение: ");
                    element.print();
                    break;
                }
            }
        }

        public static void findLastMatch(List<TextProcessor> collection)
        {
            TextProcessor tempObjectMSW = new MicrosoftWord(new string[0]); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            TextProcessor tempObjectMSW98 = new MicrosoftWord98(new string[0]); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            TextProcessor tempObjectLOW = new LibreOfficeWriter(new string[0], 1); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            tempObjectMSW.SourceCode = Helper.readKeysSearchCode();
            tempObjectMSW98.SourceCode = tempObjectMSW.SourceCode;
            tempObjectLOW.SourceCode = tempObjectMSW.SourceCode;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (tempObjectMSW.Equals(collection[i]))
                {
                    Console.WriteLine("Найдено первое сопадение: ");
                    ((TextProcessor)collection[i]).print();
                    break;
                }
                if (tempObjectMSW98.Equals(collection[i]))
                {
                    Console.WriteLine("Найдено первое сопадение: ");
                    ((TextProcessor)collection[i]).print();
                    break;
                }
                if (tempObjectLOW.Equals(collection[i]))
                {
                    Console.WriteLine("Найдено первое сопадение: ");
                    ((TextProcessor)collection[i]).print();
                    break;
                }
            }
        }

        public static void removeByIndex(List<TextProcessor> collection)
        {
            collection.RemoveAt(Helper.readKeysIndex());
        }

        public static void removeByMatch(List<TextProcessor> collection)
        {
            TextProcessor tempObjectMSW = new MicrosoftWord(new string[0]); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            TextProcessor tempObjectMSW98 = new MicrosoftWord98(new string[0]); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            TextProcessor tempObjectLOW = new LibreOfficeWriter(new string[0], 1); // создаем экземпляр пустышку, в который вносим искомый текст SourceCode
            tempObjectMSW.SourceCode = Helper.readKeysSearchCode();
            tempObjectMSW98.SourceCode = tempObjectMSW.SourceCode;
            tempObjectLOW.SourceCode = tempObjectMSW.SourceCode;
            foreach (TextProcessor element in collection)
            {
                if (tempObjectMSW.Equals(element))
                {
                    collection.Remove(element);
                    break;
                }
                if (tempObjectMSW98.Equals(element))
                {
                    collection.Remove(element);
                    break;
                }
                if (tempObjectLOW.Equals(element))
                {
                    collection.Remove(element);
                    break;
                }
            }
        }

        public static void reverseCollection(List<TextProcessor> collection)
        {
            collection.Reverse();
        }

        public static void sortCollection(List<TextProcessor> collection)
        {
            collection.Sort();
        }

        public static void runMultipliableInterface(List<TextProcessor> collection)
        {
            for (int i = 0; i < collection.Count; i++) {
                if (collection[i] is Multipliable)
                {
                    ((Multipliable)collection[i]).Mult();
                }
            }


        }
    }
}
