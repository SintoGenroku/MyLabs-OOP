using System;
using System.Collections.Generic;

namespace kontrolnaya
{

    public class SuperCollection<T>
    {
        List<string> data;

        public bool Add<T>(T element)
        {
            Type strtype = typeof(string);
            string sElement = element as string;
            if (sElement != null)
            {
                data.Add(sElement);
                return true;
            }
            else throw new NotCorrectTypeException("Введите данные с другим типом");
           
            
        }
    }

    public class NotCorrectTypeException : Exception
    {
        public NotCorrectTypeException(string Message) : base()
        {

        }
    }

    public class Point
    {
        public delegate void dclear();
        public delegate int dsum();

        public int x;
        public int y;

        public void Clear()
        {
            this.x = 0;
            this.y = 0;
        }

        public int GetSum()
        {
            return this.x + this.y;
        }

        public void Delegates()
        {
            dclear clear = Clear;
            dsum sum = GetSum;

            Console.WriteLine(sum());
            clear();
            Console.WriteLine(sum());
        }
    }

   
}
