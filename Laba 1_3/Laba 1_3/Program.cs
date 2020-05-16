using System;

namespace Laba_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainStation Minsk = new TrainStation("Minsk");
            Train Train1 = new Train(Minsk, 100);
            for (int i = 0; i < 10; i++)
            {
                Train1.addOneWagon();
            }

            Console.WriteLine("Total train weigth = " + Train1.getTotalTrainWeigth());
            Console.WriteLine("Train contains wagons: " + Train1.getAllWagons());

            foreach (Wagon wagon in Train1.Wagons)
            {
                foreach (Cargo cargo in wagon.CargoLoad)
                {
                    cargo.incrementCargoWeigth();
                }
            }

            Console.WriteLine("Total train weigth after increment = " + Train1.getTotalTrainWeigth());

        }
    }
}
