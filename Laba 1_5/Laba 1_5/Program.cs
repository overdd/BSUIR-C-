using System;
using System.Collections;
using Laba_1_5.Task_5;

namespace Laba_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileFormatsWord = { "doc", "rtf" };
            string[] fileFormatsWord98 = { "doc", "rtf", "pdf" };
            string[] fileFormatsWord2007 = { "doc", "docx", "rtf", "pdf" };
            MicrosoftWord microsoftWord = new MicrosoftWord98(fileFormatsWord);
            MicrosoftWord98 microsoftWord98 = new MicrosoftWord98(fileFormatsWord);
            microsoftWord.print();
            microsoftWord98.print(); // склеивание метода print() 
            ((MicrosoftWord)microsoftWord98).print(); //кастинг к реализации print() в родительском классе
            microsoftWord98.printDocument(); // кастинг и обертывание

            Multipliable[] documents = new Multipliable[3]
            { new MicrosoftWord(fileFormatsWord2007), new MicrosoftWord98(fileFormatsWord), new MicrosoftWord(fileFormatsWord98)};
            foreach (Multipliable element in documents)
            {
                if (element is upperCaseable)
                    ((upperCaseable)element).Up();
            }

            Console.WriteLine("Before sorting");                 // сортируем по количеству поддерживаемых форматов
            foreach (TextProcessor element in documents)
            {
                Console.WriteLine(element.printSupportedFormats());
            }
            Array.Sort(documents);
            Console.WriteLine("After sorting");
            foreach (TextProcessor element in documents)
            {
                Console.WriteLine(element.printSupportedFormats());
            }

            LibreOfficeWriter[] LOWDocs = new LibreOfficeWriter[3]
            { new LibreOfficeWriter(fileFormatsWord98, 7.1), new LibreOfficeWriter(fileFormatsWord2007, 6.0), new LibreOfficeWriter(fileFormatsWord, 8.1)};

            Console.WriteLine("Before sorting");                 // сортируем по с помощью IComparer по версии и количеству форматов
            foreach (LibreOfficeWriter element in LOWDocs)
            {
                element.print();
            }
            Array.Sort(LOWDocs, new LibreOfficeWriterVersionComparer());
            Console.WriteLine("After Version sorting");
            foreach (LibreOfficeWriter element in LOWDocs)
            {
                element.print();
            }
            Array.Sort(LOWDocs, new LibreOfficeWriterFormatsComparer());
            Console.WriteLine("After Supported formats sorting");
            foreach (LibreOfficeWriter element in LOWDocs)
            {
                element.print();
            }
            while (true)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("*     Главное меню         *");
                Console.WriteLine("****************************");
                Console.WriteLine("1 – вывод названий месяцев от start до end");
                Console.WriteLine("2 – вывод чисел Фибоначчи от start до end");
                Console.WriteLine("3 – вывод случайных букв в диапазоне от start до end без повтора");
                Console.WriteLine("4 – вывод арифметической прогрессии от start до end с шагом 13");
                Console.WriteLine("5 – вывод геометрической прогрессии от start до end с шагом 2");
                Console.WriteLine("6 – вывод названий дней недели от start до end");
                Console.WriteLine("7 – вывод квадратов чисел от start до end");
                Console.WriteLine("8 – вывод чисел, кратных 7 или 13 от start до end");
                Console.WriteLine("9 – значения факториала от start не больше end");
                Console.WriteLine("10 – вывод високосных годов от start до end");
                Console.WriteLine("0 – выход");
                int otvet = Convert.ToInt32(Console.ReadLine());
                switch (otvet)
                {
                    case 1: Executor.method1(); break;
                    case 2: Executor.method2(); break;
                    case 3: Executor.method3(); break;
                    case 4: Executor.method4(); break;
                    case 5: Executor.method5(); break;
                    case 6: Executor.method6(); break;
                    case 7: Executor.method7(); break;
                    case 8: Executor.method8(); break;
                    case 9: Executor.method9(); break;
                    case 10: Executor.method10(); break;
                    default: return;
                }
            }
        }
    }
}
