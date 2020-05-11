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

        public char this[int index]
        {
            get
            {
                return
                        ArrayChars[index];
            }
            set
            {
                ArrayChars[index] = value;
            }
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
                    flag = false;
                }
            }
            return flag;
        }

        public static SetOfChars operator +(SetOfChars A, SetOfChars B)
        {
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
            return temp;
        }

        public static SetOfChars operator -(SetOfChars A, SetOfChars B)
        {
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
            return temp;
        }

        public static explicit operator SetOfChars(string v)
        {
            return new SetOfChars(v.ToCharArray());
        }

        public static SetOfChars operator *(SetOfChars A, SetOfChars B)
        {
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
                    return tempCharA.SequenceEqual(tempCharB);
                }
                else
                {
                    return false;
                };
            }
            else
            {
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
                    return tempCharA.SequenceEqual(tempCharB);
                }
                else
                {
                    return false;
                };
            }
            else
            {
                return false;
            }
        }

        public static SetOfChars operator ++(SetOfChars A)
        {
            char[] tempCharArray = new char[A.ArrayChars.Length];
            for (int i = 0; i < A.ArrayChars.Length; i++)
            {
                tempCharArray[i] = (char)((int)A.ArrayChars[i] + 1);
            }
            return new SetOfChars(tempCharArray);
        }

        public static SetOfChars operator --(SetOfChars A)
        {
            char[] tempCharArray = new char[A.ArrayChars.Length];
            for (int i = 0; i < A.ArrayChars.Length; i++)
            {
                tempCharArray[i] = (char)((int)A.ArrayChars[i] - 1);
            }
            return new SetOfChars(tempCharArray);
        }

        public static bool operator >(SetOfChars A, SetOfChars B)
        {
            int counterA = 0;
            int counterB = 0;
            foreach (char element in A.ArrayChars)
            {
                counterA += (int)element;
            }
            foreach (char element in B.ArrayChars)
            {
                counterB += (int)element;
            }

            return (counterA > counterB) ? true : false;
        }

        public static bool operator <(SetOfChars A, SetOfChars B)
        {
            int counterA = 0;
            int counterB = 0;
            foreach (char element in A.ArrayChars)
            {
                counterA += (int)element;
            }
            foreach (char element in B.ArrayChars)
            {
                counterB += (int)element;
            }
            return (counterA > counterB) ? false : true;
        }


        public static bool operator true(SetOfChars A)
        {
            return (A.ArrayChars == null) ? false : true;
        }

        public static bool operator false(SetOfChars A)
        {
            return (A.ArrayChars == null) ? false : true;
        }

        public static implicit operator string(SetOfChars v)
        {
            StringBuilder sb = new StringBuilder("");
            foreach (char element in v.ArrayChars)
                sb.Append(element);
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            foreach (char element in ArrayChars)
                sb.Append(element);
            return sb.ToString();
        }
        public override bool Equals(object o)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}

