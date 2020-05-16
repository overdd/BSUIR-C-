using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_3
{
    class Cargo
    {
        public string CargoId { get; set; }
        public int CargoWeigth { get; set; }

        public Cargo()
        {
            Random random = new Random();
            CargoId = ("CID-" + random.Next(100, 1000).ToString());
            CargoWeigth = random.Next(0,10);
        }
    }
}
