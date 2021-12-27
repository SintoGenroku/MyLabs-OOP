using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace йцу
{
    class SuperList<T>:List<T> where T : class
    {
        public static SuperList<T> operator +(SuperList<T> l1, T l2)
        {
            if (l1.Count <= 3) 
            {
                l1.Add(l2);

            }
            
            else throw new IndexOutOfRangeException("out of range( more than 3)");
            
            return l1;
        }
    }
}
