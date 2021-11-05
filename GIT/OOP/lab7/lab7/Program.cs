using System;
using System.Diagnostics;

namespace lab7
{
    partial class Printer
    {
        public void IAmPrinter()
        {
            Console.WriteLine("Hi, I am Printer!");
        }
    }
    enum counter
    {
        one = 1,
        two,
        three,
        four,
        five
    }

    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello World!");
            Geometry obj = new Circle(5);
            Circle ball = obj as Circle;
            Circle Sun = new Circle(5000);
            Rectangle tv = new Rectangle(160, 90);
            Rectangle box = new Rectangle(35, 35);
            ball.ShowInfo();
            object obj2 = "str";
            if (obj2 is Rectangle q)
            {
                q.ShowInfo();
            }


            Printer prnt = new Printer { };
            Figure[] tps = { ball, box, Sun, tv };
            for (int i = 0; i < tps.Length; i++)
            {
                Console.WriteLine(prnt.IAmPrinting(tps[i]));
            }
            User student = new User("Maxim", "Business", 9);
            student.DisplayInfo();
            Container UI = new Container(ball, tv, box);
            Controller controll = new Controller();
            UI.Append(Sun);
            UI.Append(ball);
            controll.TotalSquare(UI);
           */
            //************************

            Console.WriteLine("enter a numbers to calculating");
            var a  = Int32.Parse(Console.ReadLine());
            var b = Int32.Parse(Console.ReadLine());
           
            try
            {
                a /= b;
                Console.WriteLine(a);
            }
            catch 
            {
                Console.WriteLine("Нou cannot divide by zero!");
            }
            finally
            {
                Console.WriteLine("Calculating is over, i goin to sleep. Chao");
            }
            Console.WriteLine("Ты кто?");
            var name = Console.ReadLine();
            var surname =Console.ReadLine();
            var age = Int32.Parse(Console.ReadLine());

            try
            {
                User loh = new User(name, surname, age);
            }
            catch (UserException ex)
            {
                Console.WriteLine("Error:  " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("Невоспитанные нам пользователи не нужны");
            }

            try
            {
                Circle box = new Circle(-30);
                Rectangle tv = new Rectangle(12, -10);
            }
            catch (FigureException ex)
            {
                Console.WriteLine("Error:  " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("wubbalubbadubdub");
            }
               

            bool isLabPassed = true;
            int intNumber = 15;
            string str = "54";
            try
            {
                isLabPassed = Convert.ToBoolean(intNumber);
            }

            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            try
            {
                intNumber = Convert.ToInt32(str);
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
