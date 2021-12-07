using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public delegate void IsJobDone();
    
    class Director
    {
        public event IsJobDone minusbabki;
        public event IsJobDone plusbabki; 
        

        private bool jobDone;
        public int Salary{ get; set; }

        public Director( int salary, bool jobDone = false) 
        {
            this.Salary = salary;
            this.jobDone = jobDone;
        }



        public void EndOfMonth()
        {
            if (jobDone)
            {
                plusbabki();
            }
            else
            {
                minusbabki();
            }
        }
        public void DisplayMessage() 
        {
            Console.WriteLine($"Выполнил таск:{jobDone}\n З/П:{Salary}");
        }
    }
}
