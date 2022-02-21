using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{   
    [Serializable]
    public class Owner
    {
        public BankAccount bankAccount;
        public DateTime birthday;

        public string fullname;
        public string _passport;
        public string nation;
        
        public bool _haveSms;
        public bool _haveNetbanking;

        public string SmsHelp;
        public string Netbanking;
        public Owner(BankAccount bankAcc, DateTime bd, string fullname, string passport, string nation, bool sms, bool netbank)
        {   
            bankAccount = bankAcc;
            birthday = bd;
            this.fullname = fullname;
            _passport = passport;
            this.nation = nation;
            _haveSms = sms;
            _haveNetbanking = netbank;
            SmsHelp = _haveSms ? "sms-оповещения подключены" : "sms-оповещения отключены";
            Netbanking = _haveNetbanking ? "Интернет банкинг подключен" : "Интернет Банкинг отключен";
        }

        public string ShowInfo()
        {
            string userInfo = $"\nФИО: {fullname}\t Гражданство:{nation}";
            userInfo += $"\tДата регистрации:{bankAccount.creationDate}\t Счёт:{bankAccount.cash}\n";
            userInfo += $"{SmsHelp}\t {Netbanking}\n";

            return userInfo;
        }
    }
}
