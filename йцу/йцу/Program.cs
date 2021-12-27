using System;

namespace йцу
{
    class Program
    {
        static void Main(string[] args)
        {
           var list = new SuperList<string>();
            try
            {
                list += "qwerty";
                list += "asdf";
                list += "zxcv";
                list += "...";
                list += "...";
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
            }        
             
        }
    }
}
