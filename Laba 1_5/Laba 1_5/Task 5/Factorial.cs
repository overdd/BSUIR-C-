using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
    class Factorial
    {
        public int Value { get; set; }

        public Factorial(int index)
        {
            if (index >= 0)
            {
                switch (index)
                {
                    case 0:
                        Value = 1;
                        break;
                    case 1:
                        Value = 1;
                        break;
                    default:
                        Value = 1;
                        while (index > 0) {
                            Value *= index;
                            index--;
                        }
                        break;
                }
            }
        }
    }
}
