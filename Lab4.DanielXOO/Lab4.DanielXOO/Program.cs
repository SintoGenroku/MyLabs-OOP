using System;

namespace Lab4.DanielXOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var obj = new List(array);
            obj = obj + 10;
            for (int i = 0; i < obj.Size; i++)
            {
                Console.Write($"{obj[i]} ");
            }
            --obj;
            Console.WriteLine();
            for (int i = 0; i < obj.Size; i++)
            {
                Console.Write($"{obj[i]} ");
            }
        }
    }
}
