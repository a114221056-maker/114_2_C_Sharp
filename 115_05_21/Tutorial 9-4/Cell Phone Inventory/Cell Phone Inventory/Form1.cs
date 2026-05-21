using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 儲存 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 此方法會將使用者輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 用來暫存價格的變數。
            decimal price;

            // 取得手機品牌。
            phone.Brand = brandTextBox.Text;

            // 取得手機型號。
            phone.Model = modelTextBox.Text;

            // 取得手機價格。
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息。
                MessageBox.Show("價格格式不正確");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // 建立新的 CellPhone 物件並取得使用者輸入的資料
            CellPhone phone = new CellPhone();
            GetPhoneData(phone);
            // 將新手機加入清單
            phoneList.Add(phone);

            // 更新 ListBox 顯示手機資訊
            phoneListBox.Items.Add($"{phone.Brand} {phone.Model} - {phone.Price}");
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
