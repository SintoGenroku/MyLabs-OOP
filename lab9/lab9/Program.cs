using System;

namespace lab9
{
    class Program
    {

        public static void StrWork(string str, Action<string> mes)
        {
            mes?.Invoke(str);
        }
        public static bool StrWork(string str, Predicate<string> mes)
        {
            return (bool)mes?.Invoke(str);
        }
        public static string StrWork(string str, string addstr, int num, Func<string, string, int, string> mes)
        {
            return mes?.Invoke(str, addstr, num);
        }

        static void Main(string[] args)
        {
            var obj = new Director(1000);
            obj.plusbabki += () =>
            {
                obj.Salary += 500;
            };
            obj.minusbabki += () =>
            {
                obj.Salary -= 500;
            };
            obj.EndOfMonth();

            var obj1 = new Director(700, true);
            obj1.plusbabki += () =>
            {
                obj1.Salary += 300;
            };
            obj1.minusbabki += () =>
            {
                obj1.Salary -= 300;
            };
            obj1.EndOfMonth();

            obj.DisplayMessage();
            obj1.DisplayMessage();

            StrWork("All, foaming, marks. are: dissapear!!!!!", StrOperations.DelFoamingMarks);
            StrWork("There 1s No Space Between", StrOperations.DelSpace);
            StrWork("stringbeacametouppercase", StrOperations.Uppercase);
            StrWork("stringbeacametolowercase", StrOperations.Lowercase);
            Console.WriteLine(StrWork("Is is just scared?", "evil magic or you", 6, StrOperations.AddElements));
        }
    }
}
