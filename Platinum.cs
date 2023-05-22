using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcard_factroy
{
    internal class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return GetType().Name;
        }

        public int GetCreditLimit()
        {
            return 20_000;
        }

        public int GetAnnualCharge()
        {
            return 2_000;
        }
    }
}
