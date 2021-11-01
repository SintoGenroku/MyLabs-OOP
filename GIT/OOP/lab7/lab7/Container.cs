using System;
using System.Collections.Generic;
using System.Linq;

namespace lab7
{
    class Container
    {
        private List<Figure> _arr;
        public List<Figure> Array
        {
            get
            {
                return _arr;
            }

            set
            {
                _arr = value;
            }
        }

        public Container(params Figure[] q)
        {
            _arr = q.ToList();
        }
        public void Append(Figure item) =>
            _arr.Add(item);


    }
}
