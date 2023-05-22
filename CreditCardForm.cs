using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creditcard_factroy
{
    public partial class CreditCardForm : Form
    {
        private readonly ICreditCard? creditCard;
        public bool ValidCreditCard { get; private set; }

        public CreditCardForm(string cardType)
        {
            InitializeComponent();

            creditCard = CreditCardFactory.GetCreditCard(cardType);
            ValidCreditCard = creditCard != null;
        }

        private void CreditCardForm_Load(object sender, EventArgs e)
        {
            if (creditCard is null)
                return;

            labelCardType.Text = creditCard.GetCardType();
            labelLimit.Text = creditCard.GetCreditLimit().ToString("N0");
            labelAnnualCharge.Text = creditCard.GetAnnualCharge().ToString("N0");
        }
    }

}
