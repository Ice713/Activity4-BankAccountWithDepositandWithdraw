using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4_BankAccountWithDepositandWithdraw
{
    public partial class Form1 : Form
    {
        BankAccount account = new BankAccount(1000);
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Current Balance: {account.Balance:C}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxTransactionType.SelectedItem.ToString())
                {
                    case "Withdraw":
                        account.Withdraw(Decimal.Parse(numericUpDownAmount.Text));
                        MessageBox.Show($"Previous Balance: {account.Balance + Decimal.Parse(numericUpDownAmount.Text):C}\nWithdraw: {Decimal.Parse(numericUpDownAmount.Text):C}\nNew Balance: {account.Balance:C}");
                        break;
                    case "Deposit":
                        account.Deposit(Decimal.Parse(numericUpDownAmount.Text));
                        MessageBox.Show($"Previous Balance: {account.Balance - Decimal.Parse(numericUpDownAmount.Text):C}\nDeposit: {Decimal.Parse(numericUpDownAmount.Text):C}\nNew Balance: {account.Balance:C}");
                        break;
                    default:
                        MessageBox.Show("Please select a valid transaction type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
