using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 此方法會將使用者在表單中輸入的資料指派到該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 從表單讀取品牌與型號，並嘗試解析價格為 decimal。
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            // 嘗試解析使用者輸入的價格（若成功則指派給 phone.Price）
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price;
            }
            else
            {
                // 若解析失敗，顯示錯誤訊息並將價格預設為 0
                MessageBox.Show("請輸入有效的價格。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone.Price = 0m; // 預設價格為 0
            }

            // 在輸出標籤中顯示物件的屬性
            brandLabel.Text = phone.Brand;
            modelLabel.Text = phone.Model;
            priceLabel.Text = phone.Price.ToString("C");
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // 建立 CellPhone 類別的新實例，並從表單讀取資料填入
            CellPhone myPhone = new CellPhone();    

            GetPhoneData(myPhone);  
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
