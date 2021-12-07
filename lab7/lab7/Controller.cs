using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Controller
    {
        public void TotalSquare(Container q)
        {
            double sum = 0;
            foreach (Figure item in q.Array)
            {
                sum += item.area;
            }
            Console.WriteLine($"Total area is:{sum}");
        }
    }
}
