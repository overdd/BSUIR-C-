using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_1
{
    class Shop
    {
        public string ShopName { get; } = "Standart shop name";
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

        public Shop(int shopStaffNumber, float totalRevenue, float averageStaffCompensation, float totalCostOfGoodsSold, float totalOverheadCosts)
        {
            _ = (shopStaffNumber > 0 & shopStaffNumber < 30) ? this.shopStaffNumber = shopStaffNumber : this.shopStaffNumber = 0;

            _ = totalRevenue >= 0 ? this.totalRevenue = totalRevenue : this.totalRevenue = 0;

            _ = averageStaffCompensation >= 0 ? this.averageStaffCompensation = averageStaffCompensation : this.averageStaffCompensation = 0;

            _ = totalCostOfGoodsSold >= 0 ? this.totalCostOfGoodsSold = totalCostOfGoodsSold : this.totalCostOfGoodsSold = 0;

            _ = totalOverheadCosts >= 0 ? this.totalOverheadCosts = totalOverheadCosts : this.totalOverheadCosts = 0;
        }

        public Shop() : this(1, 10000, 450, 8000, 500)   //конструктор без аргументов
        {
        }

        //конструктор с частью аргументов
        public Shop(int shopStaffNumber, float totalRevenue, float averageStaffCompensation) : this(shopStaffNumber, totalRevenue, averageStaffCompensation, 0, 0)
        {
        }

        //метод Print()
        public void Print() => Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", ShopName, ShopStaffNumber, TotalRevenue, AverageStaffCompensation, TotalCostOfGoodsSold, TotalOverheadCosts);

        public void BonusCalculator()
        {
            float bonus = (TotalRevenue - TotalCostOfGoodsSold - AverageStaffCompensation * ShopStaffNumber - TotalOverheadCosts) / ShopStaffNumber;
            Console.WriteLine("Премия для магазина = {0}", bonus);
        }

        public void ProfitabilityFallIndicator()
        {
            bool fallFlag;
            _ = ((TotalRevenue - TotalCostOfGoodsSold - AverageStaffCompensation * ShopStaffNumber - TotalOverheadCosts) < TotalRevenue * 0.1) ? fallFlag = true : fallFlag = false;
            if (fallFlag == true)
                Console.WriteLine("Увы, рентабельность упала ниже 10% от выручки!");
            else
                Console.WriteLine("Рентабельность выше 10% от выручки!");
        }

        public bool ProfitabilityComparator(Shop shop2)
        {
            float profitabilityShop1 = (TotalRevenue - TotalCostOfGoodsSold - AverageStaffCompensation * ShopStaffNumber - TotalOverheadCosts) / TotalRevenue;
            float profitabilityShop2 = (shop2.TotalRevenue - shop2.TotalCostOfGoodsSold - shop2.AverageStaffCompensation * shop2.ShopStaffNumber - shop2.TotalOverheadCosts) / shop2.TotalRevenue;
            if (profitabilityShop1 > profitabilityShop2)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
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
            Console.WriteLine("Shop with max profitability is:");
            shopWithMaxProfitability.Print();
            return shopWithMaxProfitability;
        }

    }
}
