using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{

        public sealed class Circle : Figure, Geometry
        {

            private double radius {
            get { return radius; }
            set
            {
                if (value <= 0)
                    throw new FigureException("Radius is can't be less than 0 or be equal");
                else
                    radius = value;
            }
        }
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
                double per = Math.PI * 2 * radius;
                return per;
            }
            public double Area()
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
