namespace creditcard_factroy
{
    partial class CreditCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLimit = new Label();
            labelCardType = new Label();
            labelAnnualCharge = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // labelLimit
            // 
            labelLimit.AutoSize = true;
            labelLimit.Location = new Point(234, 110);
            labelLimit.Name = "labelLimit";
            labelLimit.Size = new Size(42, 20);
            labelLimit.TabIndex = 1;
            labelLimit.Text = "Limit";
            // 
            // labelCardType
            // 
            labelCardType.AutoSize = true;
            labelCardType.Location = new Point(234, 41);
            labelCardType.Name = "labelCardType";
            labelCardType.Size = new Size(40, 20);
            labelCardType.TabIndex = 2;
            labelCardType.Text = "Type";
            // 
            // labelAnnualCharge
            // 
            labelAnnualCharge.AutoSize = true;
            labelAnnualCharge.Location = new Point(234, 174);
            labelAnnualCharge.Name = "labelAnnualCharge";
            labelAnnualCharge.Size = new Size(102, 20);
            labelAnnualCharge.TabIndex = 3;
            labelAnnualCharge.Text = "AnnualCharge";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Card Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 110);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 5;
            label5.Text = "Limit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 174);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 6;
            label6.Text = "Annual Charge";
            // 
            // CreditCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 257);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(labelAnnualCharge);
            Controls.Add(labelCardType);
            Controls.Add(labelLimit);
            Name = "CreditCardForm";
            Text = "CreditCardForm";
            Load += CreditCardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelLimit;
        private Label labelCardType;
        private Label labelAnnualCharge;
        private Label label1;
        private Label label5;
        private Label label6;
    }
}