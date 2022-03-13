using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [Serializable]
    public class BankAccount
    {
        public string creationDate { get; set; }
        
        public int Cash { get; set; }
        public string ContributionType { get; set; }
        public string InterestRateType { get; set; }


        public BankAccount(DateTime date, int cash, string contribution, string interestRate)
        {
            creationDate = date.ToString();
            Cash = cash;
            ContributionType = contribution;
            InterestRateType = interestRate;
        }
    }
}
