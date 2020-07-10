using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_1_7
{
    static class ExecutorP3
    {
        static StringBuilder stringBuilder;
        public static void enterStringBuider()
        {
            stringBuilder = new StringBuilder( ExecutorP1.inputString("Enter some text for StringBuilder, 30 chars max"), 30);
        }

        public static void writeStringBuilderToConsole()
        {
            Console.WriteLine(stringBuilder);
        }

        public static void insertStarAfterSymbol()
        {
            String symbol = ExecutorP1.inputString("Enter symbol. We well enter * after it.");
            stringBuilder.Replace(symbol, symbol + "*");
        }

        public static void replaceSymbols()
        {
            String oldSymbol = ExecutorP1.inputString("Enter symbol to be replaced");
            String newSymbol = ExecutorP1.inputString("Enter symbol to replace with");
            stringBuilder.Replace(oldSymbol, newSymbol);
        }

        public static void deleteSymbols()
        {
            String oldSymbol = ExecutorP1.inputString("Enter symbol(s) to be deleted");
            stringBuilder.Replace(oldSymbol, "");
        }
    }
}
