using System;

namespace Laba_1_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Shop shopAllParameters = new Shop(15, 70000, 500, 45000, 20000);
            shopAllParameters.Print();
            Shop shopNoParameters = new Shop();
            shopNoParameters.Print();
            Shop shopPartialParameters = new Shop(15, 150000, 500);
            shopPartialParameters.Print();
            shopAllParameters.BonusCalculator();
            shopNoParameters.BonusCalculator();
            shopPartialParameters.BonusCalculator();
            shopAllParameters.ProfitabilityFallIndicator();
            shopNoParameters.ProfitabilityFallIndicator();
            shopPartialParameters.ProfitabilityFallIndicator();
            shopNoParameters.ProfitabilityComparator(shopPartialParameters);
            Shop.ProfitabilityComparatorFor3Shops(shopAllParameters, shopNoParameters, shopPartialParameters);

            Console.WriteLine("ShopName: {0}", shopAllParameters.ShopName);
            Console.WriteLine("ShopStaffNumber: {0}", shopAllParameters.ShopStaffNumber);
            Console.WriteLine("TotalRevenue: {0}", shopAllParameters.TotalRevenue);
            Console.WriteLine("AverageStaffCompensation: {0}", shopAllParameters.AverageStaffCompensation);
            Console.WriteLine("TotalCostOfGoodsSold: {0}", shopAllParameters.TotalCostOfGoodsSold);
            Console.WriteLine("TotalOverheadCosts: {0}", shopAllParameters.TotalOverheadCosts);
            shopAllParameters.ShopStaffNumber++;
            shopAllParameters.TotalRevenue++;
            shopAllParameters.AverageStaffCompensation++;
            shopAllParameters.TotalCostOfGoodsSold++;
            shopAllParameters.TotalOverheadCosts++;
            shopAllParameters.Print();
            Shop shopClone = shopAllParameters;
            shopAllParameters.TotalOverheadCosts = 4;
            Console.WriteLine("shopAllParameters.TotalOverheadCosts = {0}, shopClone.TotalOverheadCosts = {1}", shopAllParameters.TotalOverheadCosts, shopClone.TotalOverheadCosts);
        }
    }
}
