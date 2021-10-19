using System;


namespace lab5
{
    public abstract class Figure
    {
        public abstract void ShowInfo();
        public string Color()
        {
            int pos = rand.Next(0, 7);
            string c = coloration[pos];
            return c;
        }

        public static string[] coloration = { "cyan", "blue", "green", "yellow", "red", "orange", "purple" };
        public static Random rand = new Random();

    }
}
