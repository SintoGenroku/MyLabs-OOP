using System;
namespace lab8
{
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            TmpClass<string> jinja = new TmpClass<string>();
            jinja.Connect("12");
            jinja.Connect("13");
            jinja.Connect("str");
            jinja.Connect("striing");
            jinja.Show();
            Console.WriteLine(jinja.GetType());


            var inv = new TmpClass<Array>();
            inv.Connect(new Array());
            

            var inv2 = new TmpClass<Type<int>>();
            inv2.Connect(new Type<int> { Value = 320494 });
            inv2.Write();

            var inv3 = new TmpClass<Array>();
            inv3.Read();
           inv3.Show();
            
        }
    }
}
