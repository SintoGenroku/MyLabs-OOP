using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public delegate void IsJobDone();
    
    class Director
    {
        IsJobDone solution;
       // event EndOfMonth SalaryTime; 
        private int salary;
        private string post;
        private int lvl;
        private bool jobDone;

        public Director(string post, int salary, int lvl = 1, bool jobDone = false) 
        {
            this.salary = salary;
            this.post = post;
            this.lvl = lvl;
            this.jobDone = jobDone;
        }

        public void EndOfMonth()
        {
            if (jobDone)
            {
                solution = ToRaise;
            }
            else
            {
                solution = Penalty;
            }
        }
        public void ToRaise() =>        
            ++lvl;

        public void ToReduce() =>
            lvl = (lvl > 1) ? --lvl : lvl;

        public void Bonus() =>
            salary += 500;
        public void Penalty() =>
            salary = (salary>500) ? salary -= 500 : salary = 0;
        

    }
}
