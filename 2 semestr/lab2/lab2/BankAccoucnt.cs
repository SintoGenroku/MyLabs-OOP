using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class BankAccount
    {
        public string creationDate;
        //private int _bankId;
        public int cash;
        private string _contributionType;
        private string _interestRateType;
        

        public BankAccount(DateTime date, int cash, string contribution, string interestRate)
        {
            this.creationDate = date.ToString();
            this.cash = cash;
            this._contributionType = contribution;
            this._interestRateType = interestRate;
        }
    }
}
