using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Geometry obj = new Circle(5);
            Circle ball = obj as Circle;
            Circle Sun = new Circle(5000);
            Rectangle tv = new Rectangle(160, 90);
            Rectangle box = new Rectangle(35, 35);
            ball.ShowInfo();
            object obj2 = "str";
            if (obj2 is Rectangle q)
            {
                q.ShowInfo();
            }


            Printer prnt = new Printer { };
            Figure[] tps = { ball, box, Sun, tv};
            for (int i = 0; i < tps.Length; i++)
            {
                Console.WriteLine(prnt.IAmPrinting(tps[i]));
            }
        }
    }
}
    