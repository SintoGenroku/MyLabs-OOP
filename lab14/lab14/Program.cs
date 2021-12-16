using System;


namespace lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry obj = new Circle(5);
            Circle ball = obj as Circle;
            Circle Sun = new Circle(5000);

        }
    }
}
