using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulator
{
    class BankAccount
    {
        // 帳戶相關私有欄位
        private decimal balance;       // 帳戶餘額
        private string name;           // 帳戶持有人姓名
        private string accountNumber;  // 帳號
        // 建構子：使用帳號、姓名與初始餘額建立帳戶
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = initialBalance;
        }

        // 取得目前餘額（唯讀屬性）
        public decimal Balance
        {
            get { return balance; }
        }

        // 存款方法：若金額大於零則加入餘額
        public void Deposit(decimal amount)
        {
            if (amount > 0m)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("存款金額必須大於零。");
            }
        }

        // 提款方法：若金額介於 0 與餘額之間則扣款，否則丟出例外
        public void Withdraw(decimal amount)
        {
            if (amount <= 0m)
                throw new ArgumentException("提款金額必須大於零。");

            if (amount > balance)
                throw new InvalidOperationException("餘額不足。");

            balance -= amount;
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      }
}
