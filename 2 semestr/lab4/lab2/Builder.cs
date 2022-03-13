using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Builder
    {
        public abstract void UpdateUser(Owner user);
        public abstract void ResetBankAcc();
        public abstract void ResetSmsHelp();
        public abstract void ResetNetbankHelp();
        public abstract Owner GetUser();
    }

    class ConcreteBuilder : Builder
    {
        private Owner currentBuilder;
        public override void ResetNetbankHelp()
        {
            currentBuilder.Netbanking = "интеренет-банкинг отключен";
        }

        public override void ResetSmsHelp()
        {
            currentBuilder.SmsHelp = "смс-оповещения отключены";

        }

        public override void UpdateUser(Owner user)
        {
            currentBuilder = user;
        }

        public override Owner GetUser()
        {
            return currentBuilder;
        }

        public override void ResetBankAcc()
        {
            currentBuilder.bankAccount.Cash = 0;
        }
    }

    class Director
    {
        private Builder _builder;
        public Director(Builder _builder)
        {
            this._builder = _builder;
        }
        public void Construct( Owner User, bool resetCash, bool resetSms, bool resetNetBank) 
        {
            _builder.UpdateUser(User);
            if(resetCash) _builder.ResetBankAcc();
            if(resetSms) _builder.ResetSmsHelp();
            if(resetNetBank) _builder.ResetNetbankHelp();
        }
    }
}
