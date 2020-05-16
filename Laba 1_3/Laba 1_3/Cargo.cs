using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_3
{
    class Cargo
    {
        public string CargoId { get; set; }
        public int CargoWeigth { get; set; }
        Random random = new Random();

        public Cargo()
        {
            CargoId = ("CID-" + random.Next(100, 1000).ToString());
            CargoWeigth = random.Next(0, 10);
        }

        public void incrementCargoWeigth()
        {
            CargoWeigth++;
        }

        public void decrementCargoWeigth()
        {
            CargoWeigth--;
        }

    }
}
