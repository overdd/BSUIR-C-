using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Laba_1_5.Task_5
{
    static class Executor
    {
        public static void method1()
        {
            int[] startEnd = new StartEndReader().readKeys();
            Month[] months = new Month[12] { new Month("JAN"), new Month("FEB"), new Month("MAR"), new Month("APR"), new Month("MAY"), new Month("JUN"),
                new Month("JUL"), new Month("AUG"), new Month("SEP"), new Month("OCT"), new Month("NOV"), new Month("DEC") };
            ParametrizedClass<Month> temp = new ParametrizedClass<Month>(months, startEnd);
            foreach (Month month in temp)
            {
                Console.WriteLine(month.Name);
            }
        }

        public static void method2()
        {
            int[] startEnd = new StartEndReader().readKeys();
            Fibonacci[] values = new Fibonacci[startEnd[1]];
            for (int i = 0; i < startEnd[1]; i++)
            {
                values[i] = new Fibonacci(i);
            }
            ParametrizedClass<Fibonacci> temp = new ParametrizedClass<Fibonacci>(values, startEnd);
            foreach (Fibonacci val in temp)
            {
                Console.WriteLine(val.Value);
            }
        }

        public static void method3()
        {
            int[] startEnd = new StartEndReader().readKeys();
            String[] allChars = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Alphabet[] letters = new Alphabet[allChars.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = new Alphabet(allChars[i]);
            }

            ParametrizedClass<Alphabet> temp = new ParametrizedClass<Alphabet>(letters, startEnd);
            temp.ReturnRandom = true;        // переключаемся в рандомный итератор
            foreach (Alphabet val in temp)
            {
                Console.WriteLine(val.Letter);
            }
        }

        public static void method4()
        {
            int[] startEnd = new StartEndReader().readKeys();
            AriphmeticProgression[] values = new AriphmeticProgression[startEnd[1]];
            for (int i = 0; i < startEnd[1]; i++)
            {
                values[i] = new AriphmeticProgression(i);
            }
            ParametrizedClass<AriphmeticProgression> temp = new ParametrizedClass<AriphmeticProgression>(values, startEnd);
            foreach (AriphmeticProgression val in temp)
            {
                Console.WriteLine(val.Value);
            }
        }

        public static void method5()
        {
            int[] startEnd = new StartEndReader().readKeys();
            GeometricProgression[] values = new GeometricProgression[startEnd[1]];
            for (int i = 0; i < startEnd[1]; i++)
            {
                values[i] = new GeometricProgression(i);
            }
            ParametrizedClass<GeometricProgression> temp = new ParametrizedClass<GeometricProgression>(values, startEnd);
            foreach (GeometricProgression val in temp)
            {
                Console.WriteLine(val.Value);
            }
        }

        public static void method6()
        {
            int[] startEnd = new StartEndReader().readKeys();
            WeekDays[] days = new WeekDays[7] { new WeekDays("MON"), new WeekDays("TUE"), new WeekDays("WED"),
                new WeekDays("THU"), new WeekDays("FRI"), new WeekDays("SAT"), new WeekDays("SUN"), };
            ParametrizedClass<WeekDays> temp = new ParametrizedClass<WeekDays>(days, startEnd);
            foreach (WeekDays day in temp)
            {
                Console.WriteLine(day.Name);
            }
        }

        public static void method7()
        {
            int[] startEnd = new StartEndReader().readKeys();
            SquaredNumber[] values = new SquaredNumber[startEnd[1]];
            for (int i = 0; i < startEnd[1]; i++)
            {
                values[i] = new SquaredNumber(i);
            }
            ParametrizedClass<SquaredNumber> temp = new ParametrizedClass<SquaredNumber>(values, startEnd);
            foreach (SquaredNumber number in temp)
            {
                Console.WriteLine(number.Value);
            }
        }

        public static void method8()
        {
            int[] startEnd = new StartEndReader().readKeys();
            MultipleOf7Or13[] values = new MultipleOf7Or13[startEnd[1]];
            for (int i = 0; i < startEnd[1]; i++)
            {
                values[i] = new MultipleOf7Or13(i);
            }
            ParametrizedClass<MultipleOf7Or13> temp = new ParametrizedClass<MultipleOf7Or13>(values, startEnd);
            foreach (MultipleOf7Or13 number in temp)
            {
                if (number.Value != 0)
                    Console.WriteLine(number.Value);
            }
        }

        public static void method9()
        {
            int[] startEnd = new StartEndReader().readKeys();
            Factorial[] values = new Factorial[startEnd[1]];
            for (int i = 0; i < startEnd[1]; i++)
            {
                values[i] = new Factorial(i);
            }
            ParametrizedClass<Factorial> temp = new ParametrizedClass<Factorial>(values, startEnd);
            foreach (Factorial number in temp)
            {
                Console.WriteLine(number.Value);
            }
        }

        public static void method10()
        {
            int[] startEnd = new StartEndReader().readKeys();
            LeapYear[] values = new LeapYear[startEnd[1]];
            for (int i = 1; i < startEnd[1]; i++)
            {
                values[i] = new LeapYear(i);
            }
            ParametrizedClass<LeapYear> temp = new ParametrizedClass<LeapYear>(values, startEnd);
            foreach (LeapYear number in temp)
            {
                if (number.leapFlag)
                    Console.WriteLine(number.year);
            }
        }
    }
}
