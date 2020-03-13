using System;

namespace Laba_1_2
{
    class Program
    {
        public static char[] exampleCharArray = new char[] { 'b', 'f', 'c', 'b', 'e' };
        public static char[] exampleCharArray2 = new char[] { 'm', 'n', 'o', 'p', 'z', 'a' };
        static void Main(string[] args)
        {
            SetOfChars set1 = new SetOfChars(exampleCharArray);
            SetOfChars set2 = new SetOfChars(exampleCharArray2);
            //_ = set1 + set2;
            _ = set1 - set2;
            //_ = set1 * set2;

            //_ = (set1 == set2);
            //_ = (set1 != set2);
        }
    }
}
