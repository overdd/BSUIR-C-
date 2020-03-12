using System;

namespace Laba_1_2
{
    class Program
    {
        public static char[] exampleCharArray = new char[] { '1', '2', '3', '4', '5', '6', '7' };
        public static char[] exampleCharArray2 = new char[] { '9', '9', '9', '9', '9', '9' };
        public static int[] exampleIntArray = new int[] { 1, 2, 3, 4, 5 };
        public static int[] exampleIntArray2 = new int[] { 5, 4, 3, 2, 1 };
        static void Main(string[] args)
        {
            SetOfChars set1 = new SetOfChars(exampleCharArray);
            //Console.WriteLine(set1.ArrayChars[1].ToString());
            //set1.ArrayChars = exampleCharArray2;
            //Console.WriteLine(set1.ArrayChars[1].ToString());
            SetOfChars set2 = new SetOfChars(exampleCharArray2);
            _ = set1 + set2;
            _ = set1 - set2;
            _ = set1 * set2;

            _ = (set1 == set2);
            _ = (set1 != set2);
        }
    }
}
