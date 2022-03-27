using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    [Serializable]
    public class BankAccount
    {
        public string creationDate { get; set; }
        
        public int Cash { get; set; }
        public string ContributionType { get; set; }
        public string InterestRateType { get; set; }
        public int ID { get { return _id; } set { } }
        private int _id;


        public BankAccount(DateTime date, int cash, string contribution, string interestRate)
        {
            creationDate = date.ToString();
            Cash = cash;
            ContributionType = contribution;
            InterestRateType = interestRate;
            _id = GetHashCode();
        }
        
        public  CashMemento SaveState()
        {
            return new CashMemento(Cash, ID);
        }
        public void RestoreState(CashMemento memento)
        {
            if(memento != null)
            {
                this.Cash = memento.Cash;
                MessageBox.Show("Счет восстановлен!");
            }
            else MessageBox.Show("Error!");
        }
    }
    
    public class CashMemento
    {
        public int Cash { get; private set; }
        public int Id { get; private set; }
        public CashMemento(int Cash, int Id)
        {
            this.Cash = Cash;
            this.Id = Id;

        }
        public void Show()
        {
            MessageBox.Show($"{Cash} -- {Id}");
        }
    }
    public class CashHistory
    {
        public Stack<CashMemento> History { get; private set; }
        public CashHistory()
        {
            History = new Stack<CashMemento>();
        }
    }
    
}
