using System;


namespace Laba_1_8
{

    class Program
    {
        static void Main(string[] args)
        {
            //эта часть для себя
            //Shop shopAllParameters = new Shop(15, 70000, 500, 45000, 20000);
            //Shop shopNoParameters = new Shop();
            //Shop shopPartialParameters = new Shop(15, 150000, 500);

            //shopAllParameters.fillDelegate(shopAllParameters.BonusCalculator);
            //shopNoParameters.fillDelegate(shopNoParameters.BonusCalculator);
            //shopPartialParameters.fillDelegate(shopPartialParameters.BonusCalculator);
            //shopAllParameters.runDelegate();
            //shopNoParameters.runDelegate();
            //shopPartialParameters.runDelegate();

            // 1. Делегат без параметров
            Shop shop = new Shop();
            shop.fillDelegateVoid(method1);
            shop.fillDelegateVoid(method2);
            shop.runDelegateVoidNotParametrized();

            Shop shop1 = new Shop();
            shop1.fillDelegateVoid(delegate () { Console.WriteLine("Всем по тысяче рублей!"); });
            shop1.fillDelegateVoid(() => { Console.WriteLine("Жить будем плохо, но недолго!"); });
            shop1.fillDelegateVoid(method2);
            shop1.fillDelegateVoid(method1);
            shop1.runDelegateVoidNotParametrized();

            Console.WriteLine("Compare to groups of delegates oа different shops");
            if (shop.compareTo(shop1))
                Console.WriteLine("Delegates are equal");
            else
                Console.WriteLine("Delegates are NOT equal");
            // 2. Делегат с параметрами
            shop.fillDelegateParametrized(buyer1);
            shop.countBuyers(14);
            shop.fillDelegateParametrized(delegate (double d) { return d + 21; });
            shop.countBuyers(14);
            shop.fillDelegateParametrized((d) => { return d + 1; });
            shop.countBuyers(14);

            // 3. События

            Shop shop3 = new Shop();
            Shop shop4 = new Shop();
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            shop3.onCount += class1.message;
            shop4.onCount += class2.message;
            shop3.fillDelegateParametrized(buyer2);
            shop4.fillDelegateParametrized(buyer2);

            shop3.countBuyers(200);
            shop4.countBuyers(200);

            Console.ReadKey();
        }

        static void method1()
        {
            Console.WriteLine("Всем по 500!!!");
        }
        static void method2()
        {
            Console.WriteLine("Никто не заслужил бонус!!!");
        }

        static double buyer1(double d)
        {
            return d * 3;
        }
        static double buyer2(double d)
        {
            return d + 10;
        }
    }
}
