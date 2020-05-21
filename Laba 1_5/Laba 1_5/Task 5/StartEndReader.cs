using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
     class StartEndReader
    {
        int[] startEnd = new int[2];
        public int[] readKeys()
        {
            Console.WriteLine("Введите значение start в виде int: ");
            startEnd[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение end в виде int: ");
            startEnd[1] = Convert.ToInt32(Console.ReadLine());
            return startEnd;
        }
    }
}
