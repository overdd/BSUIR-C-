using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
    class Fibonacci
    {
        public int Value { get; set; }

        public Fibonacci(int index)
        {
            if (index >= 0)
            {
                switch (index)
                {
                    case 0:
                        Value = 0;
                        break;
                    case 1:
                        Value = 1;
                        break;
                    default:
                        Value = (new Fibonacci(index-1).Value) + (new Fibonacci(index - 2).Value);
                        break;
                }
            }
        }
    }
}
