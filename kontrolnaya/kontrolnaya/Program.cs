using System;
using System.Linq;

namespace kontrolnaya
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperCollection<int> s = new SuperCollection<int>();

            try
            {
                s.Add(11);
                s.Add("11");
                s.Add(123.123);
                s.Add(s);
            }
            catch (NotCorrectTypeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            int[] arr = new int[20];
            var q = 1;
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i*q;
                Console.WriteLine(arr[i]);
                q *= -1;
            }
            arr[5] = 0;
            arr[6] = 0;


            var ZeroAndNegativeSet = arr.Where(x => x <= 0).Count();
            Console.WriteLine($"count of numbers that <=0: {ZeroAndNegativeSet}");
           
            Point p = new Point();
            p.x = 1;
            p.y = 2;

            p.Delegates();

            Console.ReadLine();
        }
    }
}
