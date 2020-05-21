using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
    class AriphmeticProgression
    {
        public int Value { get; set; }

        public AriphmeticProgression(int index)
        {
            if (index >= 0)
            {
                switch (index)
                {
                    case 0:
                        Value = 0;
                        break;
                    default:
                        Value = (index*13);
                        break;
                }
            }
        }

    }
}
