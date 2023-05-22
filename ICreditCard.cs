using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcard_factroy
{
    public interface ICreditCard
    {
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
        public abstract int GetAnnualCharge();

    }
}
