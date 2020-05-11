﻿using System;

namespace Laba_1_2
{
    class Program
    {
        public static char[] exampleCharArrayPlus = new char[] { 'b', 'f', 'c', 'd', 'e' };
        public static char[] exampleCharArrayPlus2 = new char[] { 'm', 'n', 'o', 'p', 'z', 'a' };
        public static char[] exampleCharArrayMinus = new char[] { 'b', 'f', 'c', 'd', 'e' };
        public static char[] exampleCharArrayMinus2 = new char[] { 'm', 'c', 'o', 'p', 'z', 'e' };
        public static char[] exampleCharArrayIntersection = new char[] { 'b', 'f', 'c', 'd', 'e' };
        public static char[] exampleCharArrayIntersection2 = new char[] { 'm', 'c', 'o', 'b', 'z', 'd' };
        public static char[] exampleCharArrayEqual = new char[] { 'e', 'f', 'c', 'd', 'b' };
        public static char[] exampleCharArrayEqual2 = new char[] { 'b', 'f', 'c', 'd', 'e' };

        static void Main(string[] args)
        {
            SetOfChars setPlus = new SetOfChars(exampleCharArrayPlus);
            SetOfChars setPlus2 = new SetOfChars(exampleCharArrayPlus2);
            _ = setPlus + setPlus2;

            SetOfChars setMinus = new SetOfChars(exampleCharArrayMinus);
            SetOfChars setMinus2 = new SetOfChars(exampleCharArrayMinus2);
            _ = setMinus - setMinus;

            SetOfChars setIntersection = new SetOfChars(exampleCharArrayIntersection);
            SetOfChars setIntersection2 = new SetOfChars(exampleCharArrayIntersection2);
            _ = setIntersection * setIntersection2;

            SetOfChars setEqual = new SetOfChars(exampleCharArrayEqual);
            SetOfChars setEqual2 = new SetOfChars(exampleCharArrayEqual2);
            _ = (setEqual == setEqual2);
            _ = (setEqual != setEqual2);
        }
    }
}

