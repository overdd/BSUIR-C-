using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Laba_1_6
{
    public static class Executor
    {
        public static void collectionViewer(ArrayList collection)
        {
            Console.WriteLine("This collection consists of following elements: ");
            foreach (TextProcessor element in collection)
            {
                element.print();
            }
        }

        public static void addElementToCollection(ArrayList collection)
        {
            ArrayList newFormatsArray = Helper.readKeysFormats();
            string[] stringMockup = new string[newFormatsArray.Count];
            for (int i = 0; i < newFormatsArray.Count; i++)
            {
                stringMockup[i] = (string)newFormatsArray[i];
            }
            collection.Add(new MicrosoftWord(stringMockup));
        }

        public static void addElementToCollectionByIndex(ArrayList collection)
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
        public static void findFirstMatch(ArrayList collection)
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

        public static void findLastMatch(ArrayList collection)
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

        public static void removeByIndex(ArrayList collection)
        {
            collection.RemoveAt(Helper.readKeysIndex());
        }

        public static void removeByMatch(ArrayList collection)
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

        public static void reverseCollection(ArrayList collection)
        {
            collection.Reverse();
        }

        public static void sortCollection(ArrayList collection)
        {
            collection.Sort();
        }

        public static void runMultipliableInterface(ArrayList collection)
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
