using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_3
{
    class Train
    {
        public TrainStation TrainStation { get; set; }
        public int TrainNumber { get; set; }
        public Stack<Wagon> Wagons { get; set; }
        public Train(TrainStation trainStation, int trainNumber)
        {
            TrainStation = trainStation;
            TrainNumber = trainNumber;
            Wagons = new Stack<Wagon>();
        }

        public void addOneWagon()
        {
            Random random = new Random();
            Wagons.Push(new Wagon(random.Next(1, 10)));
        }

        public void removeOneWagon()
        {
            if (Wagons.Count != 0)
            {
                Wagons.Pop();
            }
            else
            {
                Console.WriteLine("The train has no wagons");
            }
        }

        public int getTotalTrainWeigth()
        {
            int count = 0;
            foreach (Wagon wagon in Wagons)
            {
                foreach (Cargo cargo in wagon.CargoLoad)
                {
                    count += cargo.CargoWeigth;
                }
            }
            return count;
        }
        public string getAllWagons()
        {
            string output = "";
            foreach (Wagon wagon in Wagons)
            {
                output += wagon.ToString();
            }
            return output;
        }
    }
}
