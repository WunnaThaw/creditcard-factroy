using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcard_factroy
{
    internal class CreditCardFactory
    {
        public static ICreditCard? GetCreditCard(string cardType)
        {
            return cardType switch
            {
                "Normal" => new Normal(),
                "Platinum" => new Platinum(),
                "Titanium" => new Titanium(),
                _ => null
            };
        }
    }
}
