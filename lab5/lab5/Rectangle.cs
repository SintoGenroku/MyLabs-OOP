using System;
namespace lab5
{
    public sealed class Rectangle : Figure, Geometry
    {
        private double area { get; set; }
        private double perimeter { get; set; }
        private int width { get; set; }
        private int height { get; set; }
        private string color { get; set; }
        public Rectangle(int w, int h) 
        {
            width = w;
            height = h;
            area = w * h;
            perimeter = 2 * w + 2 * h;
            color = Color();
        }
        public double Perimeter()
        {
            return 0;
        }
        public double Area()
        {
            return 0;
        }
        override public void ShowInfo()
        {
            if (this != null)
            {
                Console.WriteLine($"Rectangle \n1)Area: {area} \n2)perimeter: {perimeter} \n3)Width: {width} \n4)Height: {height} \n4)Color: {color}");
            }
            else
            {
                Console.WriteLine("Incorrect data for Rectangle!");
            }
        }
        public override string Color() 
        {
            Console.WriteLine("Enter the color:");
            string c = Console.ReadLine();
            return c;
        }

        public override string ToString()
        {
            
            return "Rectangle override";
        }
    }
}
