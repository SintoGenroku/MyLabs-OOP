using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfLabs.Memento
{
    public static class ProductHistory
    {
        public static Stack<ProductMemento> History { get; private set; }
        static ProductHistory()
        {
            History = new Stack<ProductMemento>();
        }
    }
}
