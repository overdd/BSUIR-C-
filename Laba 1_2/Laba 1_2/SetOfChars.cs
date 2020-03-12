using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_2
{
    class SetOfChars
    {
        private char[] arrayChars;
        private int[] arrayInt;

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

        public int[] ArrayInt { get => arrayInt; set => arrayInt = value; }

        public SetOfChars(char[] arrayChars)
        {
            this.arrayChars = arrayChars;
        }

        public SetOfChars(int[] arrayInt)
        {
            this.arrayInt = arrayInt;
        }

        public SetOfChars()
        {
        }



        public bool ArrayValidityChecker(char[] arrayChars)
        {
            Array.Sort(arrayChars);
            for (int i = 0; i < arrayChars.Length - 1; i++)
            {
                Console.WriteLine(arrayChars[i]);
                if (arrayChars[i] == arrayChars[i + 1])
                    return false;
            }
            return true;
        }

        public static SetOfChars operator +(SetOfChars A, SetOfChars B)
        {
            SetOfChars temp = new SetOfChars();
            int[] exampleIntArray = new int[((A.ArrayChars.Length < B.ArrayChars.Length) ? B.ArrayChars.Length : A.ArrayChars.Length)];
            temp.ArrayInt = exampleIntArray;
            for (int i = 0; i <= (((A.ArrayChars.Length > B.ArrayChars.Length) ? B.ArrayChars.Length : A.ArrayChars.Length) - 1); i++)
            {
                temp.ArrayInt[i] = (int)A.ArrayChars[i] + (int)B.ArrayChars[i];
            }

            foreach (int item in temp.ArrayInt)
            { Console.WriteLine("{0}", item); };

            return temp;
        }


        public static SetOfChars operator -(SetOfChars A, SetOfChars B)
        {
            SetOfChars temp = new SetOfChars();
            int[] exampleIntArray = new int[((A.ArrayChars.Length < B.ArrayChars.Length) ? B.ArrayChars.Length : A.ArrayChars.Length)];
            temp.ArrayInt = exampleIntArray;
            for (int i = 0; i <= (((A.ArrayChars.Length > B.ArrayChars.Length) ? B.ArrayChars.Length : A.ArrayChars.Length) - 1); i++)
            {
                temp.ArrayInt[i] = (int)A.ArrayChars[i] - (int)B.ArrayChars[i];
            }

            foreach (int item in temp.ArrayInt)
            { Console.WriteLine("{0}", item); };

            return temp;
        }

        public static SetOfChars operator *(SetOfChars A, SetOfChars B)
        {
            SetOfChars temp = new SetOfChars();
            int[] exampleIntArray = new int[((A.ArrayChars.Length < B.ArrayChars.Length) ? B.ArrayChars.Length : A.ArrayChars.Length)];
            temp.ArrayInt = exampleIntArray;
            for (int i = 0; i <= (((A.ArrayChars.Length > B.ArrayChars.Length) ? B.ArrayChars.Length : A.ArrayChars.Length) - 1); i++)
            {
                temp.ArrayInt[i] = (int)A.ArrayChars[i] * (int)B.ArrayChars[i];
            }

            foreach (int item in temp.ArrayInt)
            { Console.WriteLine("{0}", item); };

            return temp;
        }


        public static bool operator ==(SetOfChars A, SetOfChars B)
        {
            if (A.ArrayChars.Length == B.ArrayChars.Length)
            {
                Console.WriteLine("Равны");
                return true;
            }
            else
            {
                Console.WriteLine("Не равны");
                return false;
            }
        }

        public static bool operator !=(SetOfChars A, SetOfChars B)
        {
            if (A.ArrayChars.Length != B.ArrayChars.Length)
            {
                Console.WriteLine("Истина");
                return true;
            }
            else
            {
                Console.WriteLine("Ложь");
                return false;
            }
        }

    }
}

