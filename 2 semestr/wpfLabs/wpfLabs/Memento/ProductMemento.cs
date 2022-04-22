using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfLabs.Memento
{
    public class ProductMemento
    {
        public Product Product { get; private set; }
        public int ID { get; private set; }
        public ProductMemento(Product product, int id)
        {
            Product = product;
            ID = id;
        }
    }
}
