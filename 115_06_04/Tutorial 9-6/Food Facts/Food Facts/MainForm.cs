using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        // 使用者名稱欄位（公開），可由其他表單或類別存取。
        // 預設值設為 "Chuckhu"，可依需求修改。
        public string username = "Chuckhu";

        // 如果需要也可以啟用下方屬性封裝（目前保留為註解示範） :
        // public string Username
        // {
        //     get { return username; }
        // }

        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 宣告被選取的 Fooditem 變數（稍後依單選按鈕建立實例）
            Fooditem selectedFood = null;

            // 找出被選取的單選按鈕，並將對應資料放入 selectedFood
            if (bananaRadioButton.Checked)
            {
                selectedFood = new Fooditem("一根香蕉", 100, 0.4, 27);
            }
            else if (popcornRadioButton.Checked)
            {
                selectedFood = new Fooditem("三杯爆米花", 93, 1.1, 18);
            }
            else if (muffinRadioButton.Checked)
            {
                selectedFood = new Fooditem("一個大藍莓鬆餅", 385, 9, 67);
            }

            // 若有選取食物，建立 NutritionForm 並傳入 selectedFood，然後顯示表單
            if (selectedFood != null)
            {
                NutritionForm nutriForm = new NutritionForm(selectedFood);
                nutriForm.ShowDialog();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void muffinRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
