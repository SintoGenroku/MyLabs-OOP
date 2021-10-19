using System;

namespace lab5
{
    public sealed class Circle : Figure, Geometry
    {
        private double area;
        private double perimeter;
        private double radius;
        private string color;

        public Circle(double r)
        {
            radius = r;
            color = Color();
            perimeter = Perimeter();
            area = Area();
        }
        private double Perimeter()
        {
            double per = Math.PI*2*radius;
            return per;
        }
        private  double Area()
        {
           double ar = Math.PI * Math.Sqrt(radius);
            return ar;
        }
        
        override public void ShowInfo()
        {
            if (this != null)
            {
                Console.WriteLine($"Rectangle \n1)Area: {area} \n2)Perimeter: {perimeter} \n3)Radius: {radius} \n4)Color: {color}");
            }
            else 
            {
                Console.WriteLine("Incorrect data for Circle!");
            }
        }


    }
}
