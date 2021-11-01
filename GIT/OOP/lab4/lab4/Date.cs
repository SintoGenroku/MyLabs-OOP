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
  
        public static int GetRandom()
        {
            
            Random rnd = new Random(245);          
            int value = rnd.Next();
            return value;
        }
     
    }
}
