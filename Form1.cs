namespace creditcard_factroy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new[] { "Normal", "Platinum", "Titanium", "invalidCard" };
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string cardType = comboBox1.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(cardType))
                return;

            CreditCardForm form = new(cardType);

            if (!form.ValidCreditCard)
            {
                MessageBox.Show("Invalid Card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            form.ShowDialog();
        }



    }
}