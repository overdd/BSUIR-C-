using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_3
{
    class Wagon
    {
        public static int WagonNumber { get; } = 1;
        public int WagonCapacity { get; set; }
        public Cargo[] CargoLoad { get; set; }

        public Wagon(int wagonCapacity)
        {
            WagonCapacity = wagonCapacity;
            CargoLoad = new Cargo[wagonCapacity];
            for (int i = 0; i <WagonCapacity; i++) {
                CargoLoad[i] = new Cargo();
            }
        }
    }
}
