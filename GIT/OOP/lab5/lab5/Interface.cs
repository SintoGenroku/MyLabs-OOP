using System;

namespace lab5
{
    public abstract class Figure
    {
        public double Perimeter()
        {
            return 0;
        }
         public double Area()
        {
            return 0;
        }
        public string Color()
        {
            return "ass";
        }

        public static string[] coloration = {"cyan","blue", "green", "yellow", "red", "orange", "purple" };
        public static Random rand = new Random();

    }

}

