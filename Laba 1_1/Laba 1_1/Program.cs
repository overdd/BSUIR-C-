using System;

namespace Laba_1_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Shop shopAllParameters = new Shop(15, 70000, 500, 45000, 20000);
            Console.WriteLine(shopAllParameters);
            Shop shopNoParameters = new Shop();
            Console.WriteLine(shopNoParameters);
            Shop shopPartialParameters = new Shop(15, 150000, 500);
            Console.WriteLine(shopPartialParameters);

            Console.WriteLine(shopAllParameters.BonusCalculator());
            Console.WriteLine(shopNoParameters.BonusCalculator());
            Console.WriteLine(shopPartialParameters.BonusCalculator());

            Console.WriteLine(shopAllParameters.ProfitabilityFallIndicator());
            Console.WriteLine(shopNoParameters.ProfitabilityFallIndicator());
            Console.WriteLine(shopPartialParameters.ProfitabilityFallIndicator());

            shopNoParameters.ProfitabilityComparator(shopPartialParameters);

            Console.WriteLine("Магазин с максимальной рентабельностью:");
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
            shopAllParameters.ToString();
            Shop shopClone = shopAllParameters;
            shopAllParameters.TotalOverheadCosts = 4;
            Console.WriteLine("shopAllParameters.TotalOverheadCosts = {0}, shopClone.TotalOverheadCosts = {1}", shopAllParameters.TotalOverheadCosts, shopClone.TotalOverheadCosts);
        }
    }
}
