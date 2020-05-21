using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
    class GeometricProgression
    {
        public ulong Value { get; set; }

        public GeometricProgression(int index)
        {
            if (index >= 0)
            {
                switch (index)
                {
                    case 0:
                        Value = 0;
                        break;
                    case 1:
                        Value = 2;
                        break;
                    default:
                        Value = (new GeometricProgression(index-1).Value) * 2;
                        break;
                }
            }
        }
    }
}
