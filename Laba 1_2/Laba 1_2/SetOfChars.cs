using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba_1_2
{
    internal class SetOfChars
    {
        private char[] arrayChars;

        public char[] ArrayChars
        {
            get => arrayChars; set
            {
                arrayChars = value;
                if (!ArrayValidityChecker(arrayChars))
                {
                    throw new Exception("Массив содержит повторяющиеся элементы!");
                }
            }
        }


        public SetOfChars(char[] arrayChars)
        {
            ArrayChars = arrayChars;
        }


        public SetOfChars()
        {
        }



        public bool ArrayValidityChecker(char[] arrayChars)
        {
            bool flag = true;
            if (arrayChars == null)
                Console.WriteLine("Массив - null!");
            else
                Array.Sort(arrayChars);
            for (int i = 0; i < arrayChars.Length - 1; i++)
            {
                if (arrayChars[i] == arrayChars[i + 1] && !(arrayChars[i] == '\0'))
                {
                    Console.WriteLine("В массиве повторяется элемент: " + arrayChars[i]);
                    flag = false;
                }
            }
            return flag;
        }

        public static SetOfChars operator +(SetOfChars A, SetOfChars B)
        {
            Console.WriteLine("Начало перегрузки +");
            char[] tempCharArray = new char[A.ArrayChars.Length + B.ArrayChars.Length];
            A.ArrayChars.CopyTo(tempCharArray, 0);
            B.ArrayChars.CopyTo(tempCharArray, A.ArrayChars.Length);
            SetOfChars temp = new SetOfChars();
            try
            {
                temp = new SetOfChars(tempCharArray);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            };
            Console.WriteLine("Конец перегрузки +");
            return temp;
        }


        public static SetOfChars operator -(SetOfChars A, SetOfChars B)
        {
            Console.WriteLine("Начало перегрузки -");
            char[] tempCharArray = new char[A.ArrayChars.Length];
            SetOfChars temp = new SetOfChars();
            A.ArrayChars.CopyTo(tempCharArray, 0);

            for (int i = 0; i < A.ArrayChars.Length; i++)           //обнуляем символы в итогов массиве, которые есть во втором
            {
                for (int j = 0; j < B.ArrayChars.Length; j++)
                {
                    if (A.ArrayChars[i] == B.ArrayChars[j])
                        tempCharArray[i] = '\0';
                }
            }
            try
            {
                temp = new SetOfChars(tempCharArray);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            };
            Console.WriteLine("Конец перегрузки -");
            return temp;
        }

        public static SetOfChars operator *(SetOfChars A, SetOfChars B)
        {
            Console.WriteLine("Начало перегрузки *");
            char[] tempCharArray = new char[A.ArrayChars.Length];
            SetOfChars temp = new SetOfChars();

            for (int i = 0; i < A.ArrayChars.Length; i++)
            {
                for (int j = 0; j < B.ArrayChars.Length; j++)
                {
                    if (A.ArrayChars[i] == B.ArrayChars[j])
                    {
                        tempCharArray[i] = A.ArrayChars[i];
                    }
                }
            }

            try
            {
                temp = new SetOfChars(tempCharArray);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            };
            Console.WriteLine("Конец перегрузки *");
            return temp;
        }



        public static bool operator ==(SetOfChars A, SetOfChars B)
        {
            if (A.ArrayChars.Length == B.ArrayChars.Length)
            {
                char[] tempCharA = A.ArrayChars;
                char[] tempCharB = B.ArrayChars;
                Array.Sort(tempCharA);
                Array.Sort(tempCharB);
                if (tempCharA.SequenceEqual(tempCharB))
                {
                    Console.WriteLine("Равны");
                    return tempCharA.SequenceEqual(tempCharB);
                }
                else
                {
                    Console.WriteLine("Не равны");
                    return false;
                };
            }
            else
            {
                Console.WriteLine("Не равны");
                return false;
            }
        }

        public static bool operator !=(SetOfChars A, SetOfChars B)
        {
            if (A.ArrayChars.Length == B.ArrayChars.Length)
            {
                char[] tempCharA = A.ArrayChars;
                char[] tempCharB = B.ArrayChars;
                Array.Sort(tempCharA);
                Array.Sort(tempCharB);
                if (tempCharA.SequenceEqual(tempCharB))
                {
                    Console.WriteLine("Ложь");
                    return tempCharA.SequenceEqual(tempCharB);
                }
                else
                {
                    Console.WriteLine("Истина");
                    return false;
                };
            }
            else
            {
                Console.WriteLine("Истина");
                return false;
            }
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var second = o as SetOfChars;

            return second != null && ArrayChars == second.ArrayChars;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}

