using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcard_factroy
{
    internal class CreditCardFactory
    {
        private static readonly Dictionary<string, Func<ICreditCard?>> cardTypeMappings = new ()
        {
            ["Normal"] = () => new Normal(),
            ["Platinum"] = () => new Platinum(),
            ["Titanium"] = () => new Titanium()
        };

        public ICreditCard? this[string cardType]
        {
            get
            {
                if (cardTypeMappings.TryGetValue(cardType, out Func<ICreditCard?>? cardTypeValue))
                {
                    return cardTypeValue?.Invoke();
                }

                return null;
            }
        }

        //public static ICreditCard? GetCreditCard(string cardType)
        //{
        //    return cardType switch
        //    {
        //        "Normal" => new Normal(),
        //        "Platinum" => new Platinum(),
        //        "Titanium" => new Titanium(),
        //        _ => null
        //    };
        //}
    }
}
