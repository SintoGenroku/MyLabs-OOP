using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public sealed class Rectangle : Figure, Geometry
    {

        private int width 
        {
            get { return width; }
            set
            {
                if (value < 0)
                    throw new FigureException("Width is can't be less than 0");
                else
                    width = value;
            }
        }
        private int height 
        {
            get { return height; }
            set
            {
                if (value < 0)
                    throw new FigureException("Height is can't be less than 0");
                else
                    height = value;
            }
        }
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
        public new string Color()
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
