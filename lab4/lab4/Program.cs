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
            Console.WriteLine($"{newstr.Sum(str)}");
            Array one = new Array(1,2,3);
            Array eno = new Array(3,2,1);
            Array arrSum = one + eno;
            Array arrDiff = one - eno;
            arrSum.Show();
            arrDiff.Show();
 
        }
    }
}
