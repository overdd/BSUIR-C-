using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
    class MultipleOf7Or13
    {
        public int Value { get; set; }

        public MultipleOf7Or13(int index)
        {
            if (index >= 0)
            {
                switch (index)
                {
                    case 0:
                        Value = 0;
                        break;
                    default:
                        if (index % 7 == 0 || index%13 == 0 )
                            Value = index;
                        break;
                }
            }
        }
    }
}
