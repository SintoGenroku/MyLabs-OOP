using System;

namespace lab5
{
    public class Circle : Figure
    {
        private double area;
        private double perimeter;
        private double radius;
        private string color;



    
        public new double Perimeter()
        {
            double per = Math.PI*2*radius;
            return per;
        }
        public new double Area()
        {
           double ar = Math.PI * Math.Sqrt(radius);
            return ar;
        }
        public new string Color() 
        {
            int pos = rand.Next(0, 7);
            string c = coloration[pos];
            return c;
        }
        public Circle(double r) 
        {
            radius = r;
            perimeter = Perimeter();
            area = Area();
            color = Color();
        }
    }
}
