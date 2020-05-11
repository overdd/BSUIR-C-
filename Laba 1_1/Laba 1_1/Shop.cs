using System;


namespace Laba_1_1
{
    class Shop
    {
        public string ShopName { get; } = "Standart shop name";                     //стандартное имя магазина
        private int shopStaffNumber;                                                // количество персонала
        private float totalRevenue;                                               //выручка итого
        private float averageStaffCompensation;                              // средняя зарплата персонала
        private float totalCostOfGoodsSold;                                   //стоимость проданных товаров итого
        private float totalOverheadCosts;                                     // накладные расходы итого

        public int ShopStaffNumber
        {
            get { return shopStaffNumber; }
            set
            {
                if (value >= 0 & value < 30)
                    shopStaffNumber = value;
            }
        }

        public float TotalRevenue
        {
            get => totalRevenue; set
            {
                if (value >= 0)
                    totalRevenue = value;
            }
        }

        public float AverageStaffCompensation
        {
            get => averageStaffCompensation; set
            {
                if (value >= 0)
                    averageStaffCompensation = value;
            }
        }

        public float TotalCostOfGoodsSold
        {
            get => totalCostOfGoodsSold; set
            {
                if (value >= 0)
                    totalCostOfGoodsSold = value;
            }
        }

        public float TotalOverheadCosts
        {
            get => totalOverheadCosts; set
            {
                if (value >= 0)
                    totalOverheadCosts = value;
            }
        }

        public Shop(int ShopStaffNumber, float TotalRevenue, float AverageStaffCompensation, float TotalCostOfGoodsSold, float TotalOverheadCosts)
        {
            this.ShopStaffNumber = ShopStaffNumber;
            this.TotalRevenue = TotalRevenue;
            this.AverageStaffCompensation = AverageStaffCompensation;
            this.TotalCostOfGoodsSold = TotalCostOfGoodsSold;
            this.TotalOverheadCosts = TotalOverheadCosts;
        }

        public Shop() : this(1, 10000, 450, 8000, 500)   //конструктор без аргументов
        {
        }

        //конструктор с частью аргументов
        public Shop(int ShopStaffNumber, float TotalRevenue, float AverageStaffCompensation) : this(ShopStaffNumber, TotalRevenue, AverageStaffCompensation, 0, 0)
        {
        }

        //переопределение ToString()
        public override string ToString()
        {
            return String.Format("Магазин с названием {0}, с {1} сотрудниками, выручка {2}, средняя ЗП продавца {3}, общая стоимость проданных товаров {4}, общие накладные расходы {5}", ShopName, ShopStaffNumber, TotalRevenue, AverageStaffCompensation, TotalCostOfGoodsSold, TotalOverheadCosts);
        }


        public float BonusCalculator()
        {
            return (TotalRevenue - TotalCostOfGoodsSold - AverageStaffCompensation * ShopStaffNumber - TotalOverheadCosts) / ShopStaffNumber;

        }

        public bool ProfitabilityFallIndicator()
        {
            bool fallFlag;
            return ((TotalRevenue - TotalCostOfGoodsSold - AverageStaffCompensation * ShopStaffNumber - TotalOverheadCosts) < TotalRevenue * 0.1) ? fallFlag = true : fallFlag = false;
        }

        public bool ProfitabilityComparator(Shop shop2)
        {
            float profitabilityShop1 = (TotalRevenue - TotalCostOfGoodsSold - AverageStaffCompensation * ShopStaffNumber - TotalOverheadCosts) / TotalRevenue;
            float profitabilityShop2 = (shop2.TotalRevenue - shop2.TotalCostOfGoodsSold - shop2.AverageStaffCompensation * shop2.ShopStaffNumber - shop2.TotalOverheadCosts) / shop2.TotalRevenue;
            if (profitabilityShop1 > profitabilityShop2)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        public static Shop ProfitabilityComparatorFor3Shops(Shop shop1, Shop shop2, Shop shop3)
        {
            Shop shopWithMaxProfitability;
            float max;
            float profitabilityShop1 = (shop1.TotalRevenue - shop1.TotalCostOfGoodsSold - shop1.AverageStaffCompensation * shop1.ShopStaffNumber - shop1.TotalOverheadCosts) / shop1.TotalRevenue;
            float profitabilityShop2 = (shop2.TotalRevenue - shop2.TotalCostOfGoodsSold - shop2.AverageStaffCompensation * shop2.ShopStaffNumber - shop2.TotalOverheadCosts) / shop2.TotalRevenue;
            float profitabilityShop3 = (shop3.TotalRevenue - shop3.TotalCostOfGoodsSold - shop3.AverageStaffCompensation * shop3.ShopStaffNumber - shop3.TotalOverheadCosts) / shop3.TotalRevenue;

            if (profitabilityShop1 > profitabilityShop2)
            {
                shopWithMaxProfitability = shop1;
                max = profitabilityShop1;
            }
            else
            {
                shopWithMaxProfitability = shop2;
                max = profitabilityShop2;
            }

            if (profitabilityShop3 > max)
            {
                shopWithMaxProfitability = shop3;
            }

            shopWithMaxProfitability.ToString();
            return shopWithMaxProfitability;
        }

    }
}
