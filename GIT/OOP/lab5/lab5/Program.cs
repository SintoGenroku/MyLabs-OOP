using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object obj = new Circle(5);
            Circle ball = obj as Circle;        
            ball.ShowInfo();
            object obj2 = "str";
            if (obj2 is Rectangle box)
            {
                box.ShowInfo();
            }
            


        }
    }
}
