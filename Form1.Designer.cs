namespace creditcard_factroy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShow = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(128, 154);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(226, 29);
            btnShow.TabIndex = 3;
            btnShow.Text = "show Credit Card Detail";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += BtnShow_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 28);
            comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 310);
            Controls.Add(comboBox1);
            Controls.Add(btnShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnShow;
        private ComboBox comboBox1;
    }
}