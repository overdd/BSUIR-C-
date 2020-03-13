using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_2
{
    class SetOfChars
    {
        private char[] arrayChars;


        public char[] ArrayChars
        {
            get => arrayChars; set
            {
                if (ArrayValidityChecker(arrayChars))
                    arrayChars = value;
                else
                    Console.WriteLine("Массив символов содержит неуникальные элементы!");
            }
        }


        public SetOfChars(char[] arrayChars)
        {
            this.arrayChars = arrayChars;
        }


        public SetOfChars()
        {
        }



        public bool ArrayValidityChecker(char[] arrayChars)
        {
            if (arrayChars == null)
                Console.WriteLine("Массив - null!");
            else
                Array.Sort(arrayChars);
            for (int i = 0; i < arrayChars.Length - 1; i++)
            {
                if (arrayChars[i] == arrayChars[i + 1])
                    return false;
            }
            return true;
        }

        public static SetOfChars operator +(SetOfChars A, SetOfChars B)
        {
            Console.WriteLine("Начало перегрузки +");
            char[] tempCharArray = new char[A.ArrayChars.Length + B.ArrayChars.Length];
            SetOfChars temp = new SetOfChars(tempCharArray);

            for (int i = 0; i < (A.ArrayChars.Length); i++)
            {
                temp.ArrayChars[i] = A.ArrayChars[i];
            }
            for (int i = 0; i < (B.ArrayChars.Length); i++)
            {
                temp.ArrayChars[A.ArrayChars.Length + i] = B.ArrayChars[i];
            }

            foreach (char item in temp.ArrayChars)
                Console.WriteLine("{0}", item);
            Console.WriteLine("Конец перегрузки +");
            return temp;
        }


        public static SetOfChars operator -(SetOfChars A, SetOfChars B)
        {
            Console.WriteLine("Начало перегрузки -");
            char[] tempCharArray = new char[A.ArrayChars.Length];
            SetOfChars temp = new SetOfChars(tempCharArray);

            for (int i = 0; i < A.ArrayChars.Length; i++)           //копируем первый массив в итоговый массив
                temp.ArrayChars[i] = A.ArrayChars[i];

            for (int i = 0; i < A.ArrayChars.Length; i++)           //обнуляем символы в итогов массиве, которые есть во втором
            {
                for (int j = 0; j < B.ArrayChars.Length; j++)
                {
                    if (A.ArrayChars[i] == B.ArrayChars[j])
                        temp.ArrayChars[i] = '\0';
                }
            }

            foreach (char item in temp.ArrayChars)
                Console.WriteLine("{0}", item);
            Console.WriteLine("Конец перегрузки -");
            return temp;
        }

        public static SetOfChars operator *(SetOfChars A, SetOfChars B)
        {
            Console.WriteLine("Начало перегрузки *");
            char[] tempCharArray = new char[A.ArrayChars.Length + B.ArrayChars.Length];
            SetOfChars temp = new SetOfChars(tempCharArray);

            for (int i = 0; i < A.ArrayChars.Length; i++)
            {
                for (int j = 0; j < B.ArrayChars.Length; j++)
                {
                    if (A.ArrayChars[i] == B.ArrayChars[j])
                        temp.ArrayChars[i] = A.ArrayChars[i];
                    else
                        temp.ArrayChars[i] = '\0';
                }
            }

            foreach (char item in temp.ArrayChars)
                Console.WriteLine("{0}", item);
            Console.WriteLine("Конец перегрузки *");
            return temp;
        }



        //public static bool operator ==(SetOfChars A, SetOfChars B)
        //{
        //    if (A.ArrayChars.Length == B.ArrayChars.Length)
        //    {
        //        Console.WriteLine("Равны");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Не равны");
        //        return false;
        //    }
        //}

        //public static bool operator !=(SetOfChars A, SetOfChars B)
        //{
        //    if (A.ArrayChars.Length != B.ArrayChars.Length)
        //    {
        //        Console.WriteLine("Истина");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ложь");
        //        return false;
        //    }
        //}

    }
}

