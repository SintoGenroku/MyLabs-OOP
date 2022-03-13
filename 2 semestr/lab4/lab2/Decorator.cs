using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [Serializable]
    public abstract class BankAcc
    {
        public string creationDate { get; set; }

        public int Cash { get; set; }
        public string ContributionType { get; set; }
        public string InterestRateType { get; set; }


        public BankAcc(DateTime date, int cash, string contribution, string interestRate)
        {
            creationDate = date.ToString();
            Cash = cash;
            ContributionType = contribution;
            InterestRateType = interestRate;
        }
    }
    public class CreditBankAcc : BankAcc
    {
        public CreditBankAcc(DateTime date, int cash, string contribution, string interestRate) : base(date, cash, contribution, interestRate)
        {
        }
    }

}
