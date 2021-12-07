using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab8
{
    class Type<T>
    {
        public T Value;
    }
    class TmpClass<T>:Templ<T> where T: class
    {
        internal List<T> smth;

        public TmpClass(params T [] arr)
        {
            smth = new List<T> { };
            foreach (T item in arr)
            {
                smth.Add(item);
            }
        }

        public void Connect(T item)
        {
            this.smth.Add(item);
        }

        public void Del()
        {
            Console.WriteLine($"enter position from 0 to{smth.Count}");
            int pos = Int32.Parse(Console.ReadLine());
            if (pos <= smth.Count)
            {
                smth.RemoveAt(pos);
            }
            else Console.WriteLine("invalid position");
        }

        public void Show()
        {
            foreach (T item in smth) 
            {
                Console.WriteLine($" - {item}");
            }
          
        }

        public void Write()
        {
            StreamWriter inFile = null;
            try
            {
                inFile = new StreamWriter("..//lab8.txt", false, Encoding.Default);
                inFile.WriteLine("blablablablabla");
            }
            finally
            {
                inFile.Close();
            }
        }
        public void Read()
        {
            StreamReader fromFile = null;
            try
            {
                fromFile = new StreamReader("..//lab8.txt");
                int counter = 0;

                foreach (string str in File.ReadAllLines("..//lab8.txt"))
                {
                    counter++;
                }
                string[] arr = new string[counter];
                for (int i = 0; i < counter; i++)
                {
                    arr[i] = fromFile.ReadLine();
                    Console.Write(arr[i] + "\n");
                }
            }
            finally
            {
                fromFile.Close();
            }
        }
    }
}
