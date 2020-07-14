using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_1_9
{
    class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            Thread task1 = new Thread(showEvenNumbers);
            task1.Priority = ThreadPriority.Lowest;
            task1.Start();

            Thread task2 = new Thread(showAtoZ);
            task2.Priority = ThreadPriority.AboveNormal;
            task2.Start();

            Thread task3 = new Thread(showStars);
            task3.Priority = ThreadPriority.Highest;
            task3.Start();

            Console.ReadLine();
        }

        static void showEvenNumbers()
        {
            try
            {
                Monitor.Enter(locker);
                for (int i = 0; i < 101; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }

        static void showAtoZ()
        {
            try
            {
                Monitor.Enter(locker);
                int[] symbols = Enumerable.Range('A', 'Z' - 'A' + 1).ToArray();
            foreach (int i in symbols)
                    Console.WriteLine((char)i);
            }
            finally 
            {
                Monitor.Exit(locker);
            }
        }

        static void showStars()
        {
            try
            {
                Monitor.Enter(locker);
                String star = "";
                for (int i = 1; i <= 30; i++)
                {
                    star += "*";
                    Console.WriteLine(star);
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }
    }
}
