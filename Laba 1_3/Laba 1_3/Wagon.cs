using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_3
{
    class Wagon
    {
        public int WagonNumber { get; set; }
        public int WagonCapacity { get; set; }
        public Cargo[] CargoLoad { get; set; }
        public Random random = new Random();

        public Wagon(int wagonCapacity)
        {
            WagonNumber = random.Next(0, 1000);
            WagonCapacity = wagonCapacity;
            CargoLoad = new Cargo[wagonCapacity];
            for (int i = 0; i < WagonCapacity; i++)
            {
                CargoLoad[i] = new Cargo();
            }
        }

        public void clearCargoLoad()
        {
            CargoLoad = new Cargo[WagonCapacity];
        }

        public void reloadCargoLoad()
        {
            CargoLoad = new Cargo[WagonCapacity];
            for (int i = 0; i < WagonCapacity; i++)
            {
                CargoLoad[i] = new Cargo();
            }
        }

        public int getTotalWagonWeigth()
        {
            int count = 0;
            foreach (Cargo element in CargoLoad)
            {
                count += element.CargoWeigth;
            }
            return count;
        }

        public override string ToString()
        {
            return ("Wagon No" + WagonNumber.ToString() + ", Wagon Capacity: " + WagonCapacity.ToString() + ", Total weigth: " + this.getTotalWagonWeigth()+ "\n");
        }
    }
}
