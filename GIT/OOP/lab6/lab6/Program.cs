using System;

namespace lab6  
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
    struct User
    {
        private string name;
        private string surname;
        private int age;

        public User(string n, string sn, int a) 
        {
            name = n;
            surname = sn;
            age = a;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\nName: {name} \nSurname{surname} \n Age: {age}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        }
    }
}
