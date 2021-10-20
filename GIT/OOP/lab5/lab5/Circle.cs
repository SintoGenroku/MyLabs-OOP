using System;

namespace lab5
{
    public sealed class Circle : Figure, Geometry
    {
        private double area { get; set; }
        private double perimeter { get; set; }
        private double radius { get; set; }
        private string color { get; set; }

        public Circle(double r)
        {
            radius = r;
            color = Color();
            perimeter = Perimeter();
            area = Area();
        }
        public double Perimeter()
        {
            double per = Math.PI*2*radius;
            return per;
        }
        public  double Area()
        {
           double ar = Math.PI * Math.Sqrt(radius);
            return ar;
        }
        
        override public void ShowInfo()
        {
            if (this != null)
            {
                Console.WriteLine($"Circle \n1)Area: {area} \n2)Perimeter: {perimeter} \n3)Radius: {radius} \n4)Color: {color}");
            }
            else 
            {
                Console.WriteLine("Incorrect data for Circle!");
            }
        }

        public override string ToString()
        {

            return "Circle override";
        }

    }
}
