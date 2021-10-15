namespace lab4
{
 
    public static class StringExtension
    {
        public static string VowelDel(this string str)
        {
            string buff = "AaEeIiOoUuYy";
            foreach (char e in buff)
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
    }

}
