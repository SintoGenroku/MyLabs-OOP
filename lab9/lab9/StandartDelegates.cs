using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{

    

    public class StrOperations
    {
       
      
        public string VowelDel(string str)
        {
            string vowels = "AaEeIiOoUuYy";
            foreach (char e in vowels)
            {
                str = str.Replace(e, '\0');
            }
            return str;
        }

        public static void DelFoamingMarks(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '.' && str[i] != ',' && str[i] != ':' && str[i] != ';' && str[i] != '!' && str[i] != '?')
                {
                    newstr += str[i];
                }
            }
            Console.WriteLine(newstr);
        }

        public static string AddElements(string str, string addstr, int num)
        {
            string newstr = "";
            for (int i = 0; i < num; i++)
            {
                newstr += str[i];
            }
            for (int i = 0; i < addstr.Length; i++)
            {
                newstr += addstr[i];
            }
            if (num < str.Length)
                for (int i = num - 1; i < str.Length; i++)
                {
                    newstr += str[i];
                }
            return newstr;
        }

        public static void Uppercase(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void DelSpace(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    newstr += str[i];
            }
            Console.WriteLine(newstr);
        }
        public static void Lowercase(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        /*public static void Show(this Array arr)
        {
            foreach (int e in arr._array)
            {
                Console.WriteLine(e);
            }
        }*/
    }
}
