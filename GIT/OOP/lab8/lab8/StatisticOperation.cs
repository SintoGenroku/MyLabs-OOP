using System;

namespace lab8
{

    public static class StatisticOperation
    {
        public static string VowelDel(this string str)
        {
            string vowels = "AaEeIiOoUuYy";
            foreach (char e in vowels)
            {
                str = str.Replace(e, '\0');
            }
            return str;
        }

        public static string FiveClear(this string str)
        {
            str = str.Remove(0, 5);
            return str;
        }

        public static string Sum(this string first, string second)
        {

            first = String.Concat(first, second);
            return first;
        }
        public static int LengthDiff(this string first, string second)
        {
            int diff = Math.Abs(first.Length - second.Length);
            return diff;
        }
        public static int CountOfSymbols(this string str)
        {
            return str.Length;
        }
        public static void Show(this Array arr)
        {
            foreach (int e in arr._array)
            {
                Console.WriteLine(e);
            }
        }
    }

}
