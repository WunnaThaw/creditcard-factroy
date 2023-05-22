using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcard_factroy
{
    internal class Normal : ICreditCard
    {
        public string GetCardType()
        {
            return GetType().Name;
        }

        public int GetCreditLimit()
        {
            return 10_000;
        }

        public int GetAnnualCharge()
        {
            return 1_000;
        }
    }
}
