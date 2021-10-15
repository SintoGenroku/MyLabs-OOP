using System;

namespace lab4
{
    public partial class Array
    {
        class Date
        {
            private string time { get { return time; } set { } }
            public Date()
            {
                time = "10.10.2021";
            }
            public void GetDate()
            {
                Console.WriteLine(time);
            }
        }
    }
}
