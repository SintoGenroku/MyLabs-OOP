using System;
using System.ComponentModel.DataAnnotations;
using lab2.Prototype;

namespace lab2
{
    [Serializable]
    public class Owner : Prototype<Owner>
    {
        public BankAccount bankAccount;
        public DateTime birthday;


        [Required]
        public string fullname;
        public string _passport;
        public string nation;
        
        public bool _haveSms;
        public bool _haveNetbanking;

        public string SmsHelp;
        public string Netbanking;

        public Owner()
        {
        }
        
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
            userInfo += $"\tДата регистрации:{bankAccount.creationDate}\t Счёт:{bankAccount.Cash}\n";
            userInfo += $"Тип вклада: {bankAccount.ContributionType}\t {SmsHelp}\t {Netbanking}\n";

            return userInfo;
        }
    }
}
