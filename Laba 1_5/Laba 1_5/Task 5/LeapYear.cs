using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_5.Task_5
{
    class LeapYear
    {
        public bool leapFlag;
        public int year;

        public LeapYear(int year)
        {
            this.year = year;
            if (DateTime.IsLeapYear(year))
                this.leapFlag = true;
            else
                this.leapFlag = false;
        }

    }
}
