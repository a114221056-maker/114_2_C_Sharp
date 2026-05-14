using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        // BankAccount 欄位，初始餘額為 $1000
        private BankAccount account = new BankAccount(1000m);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 在表單載入時顯示初始餘額
            balanceLabel.Text = account.Balance.ToString("C");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 處理存款按鈕點擊事件：解析輸入並呼叫帳戶的 Deposit
            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);
                balanceLabel.Text = account.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("請輸入有效的金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 處理提款按鈕點擊事件：解析輸入並呼叫帳戶的 Withdraw
            decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                account.Withdraw(amount);
                balanceLabel.Text = account.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("請輸入有效的金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
