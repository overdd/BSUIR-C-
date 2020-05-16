using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_3
{
    class Train
    {
        public TrainStation TrainStation { get; set; }
        public int TrainNumber { get; set; }
        public Wagon[] Wagons { get; set; }
        public Train(TrainStation trainStation, int trainNumber)
        {
            TrainStation = trainStation;
            TrainNumber = trainNumber;
        }
    }
}
