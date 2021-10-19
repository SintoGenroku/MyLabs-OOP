﻿using System;
namespace lab5
{
    public sealed class Rectangle : Figure, Geometry
    {
        private int area;
        private int perimeter;
        private int width;
        private int height;
        private string color;
        public Rectangle(int w, int h) 
        {
            width = w;
            height = h;
            area = w * h;
            perimeter = 2 * w + 2 * h;
            color = Color();
        }
        public int Perimeter()
        {
            return 0;
        }
        public int Area()
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
    }
}
