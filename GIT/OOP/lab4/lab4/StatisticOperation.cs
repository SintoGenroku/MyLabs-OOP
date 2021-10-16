namespace lab4
{
 
    public static class StringExtension
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
            for (int i = second.Length; i > 0 ; i--)
            {
                first.Insert(i, second[i].ToString());
            }
            return first;
        }
        public static string Difference(this string str)
        {
            return str;
        }
        public static int CountOfSymbols(this string str)
        {
            return str.Length;
        }
    }

}
