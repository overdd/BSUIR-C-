using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_6
{
    class Helper
    {

        public static int readKeysIndex()
        {
            Console.WriteLine("Введите номер индекса и нажмите Enter, для прерывания нажмите 0 ");
            return Convert.ToInt32(Console.ReadLine()); ;
        }
        public static ArrayList readKeysFormats()
        {
            ArrayList temp = new ArrayList();
            while (true)
            {
                Console.WriteLine("Введите формат и нажмите Enter, для прерывания нажмите 0 ");
                string string1 = Convert.ToString(Console.ReadLine());
                if (string1 != "0")
                {
                    temp.Add(string1);
                }
                else { break; }
            }
            return temp;
        }

        public static string readKeysSearchCode()
        {
            Console.WriteLine("Введите строку кода для поиска в поле SourceCode");
            return Convert.ToString(Console.ReadLine()); ;
        }

    }
}
