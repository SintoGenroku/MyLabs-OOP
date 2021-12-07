using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class Costs
    {
        public int Cost { get; set; }
        private int id;

        public int ID
        {
            get
            {
                return id;
            }
        }
        public Costs(int Cost, int id)
        {
            this.Cost = Cost;
            this.id = id;
        }
    }
}
