using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {  
            string str = "qwerty UIOP aSdghT";
            string newstr = str.VowelDel();
            Console.WriteLine($"{str}\n {newstr}");
            Console.WriteLine($"{str.Sum(newstr)}");
           
        }
    }
}
