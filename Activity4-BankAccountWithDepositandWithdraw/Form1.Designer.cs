namespace Activity4_BankAccountWithDepositandWithdraw
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.buttonProceed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction:";
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.comboBoxTransactionType.Location = new System.Drawing.Point(304, 52);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(144, 24);
            this.comboBoxTransactionType.TabIndex = 1;
            // 
            // buttonProceed
            // 
            this.buttonProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProceed.Location = new System.Drawing.Point(251, 121);
            this.buttonProceed.Name = "buttonProceed";
            this.buttonProceed.Size = new System.Drawing.Size(151, 32);
            this.buttonProceed.TabIndex = 3;
            this.buttonProceed.Text = "Proceed";
            this.buttonProceed.UseVisualStyleBackColor = false;
            this.buttonProceed.Click += new System.EventHandler(this.buttonProceed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount:";
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalance.Location = new System.Drawing.Point(251, 159);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(151, 38);
            this.buttonBalance.TabIndex = 5;
            this.buttonBalance.Text = "Check Balance";
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAmount.Location = new System.Drawing.Point(304, 83);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownAmount.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonProceed);
            this.Controls.Add(this.comboBoxTransactionType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Button buttonProceed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
    }
}

