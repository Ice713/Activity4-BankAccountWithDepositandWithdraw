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
            MessageBox.Show($"Current Balance: {account.Balance:C}");
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {

        }
    }
}
