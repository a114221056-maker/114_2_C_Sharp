using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    // 將類別設為 public，以便其他 public 類別或方法（例如 NutritionForm 的 public 建構子）可以使用此型別作為參數或屬性。
    public class Fooditem
    {
        // 私有欄位：儲存食物名稱
        private string name;
        // 私有欄位：儲存熱量
        private double calories;
        // 私有欄位：儲存脂肪克數
        private double fat;
        // 私有欄位：儲存碳水化合物克數
        private double carb;

        // 無參構造函式（保留）
        public Fooditem()
        {
        }

        // 建構子：使用名稱、熱量、脂肪與碳水值建立 Fooditem 實例
        public Fooditem(string name, double calories, double fat, double carb)
        {
            this.name = name;
            this.calories = calories;
            this.fat = fat;
            this.carb = carb;
        }

        // 公開屬性：食物名稱，提供外部讀取與設定的介面
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 公開屬性：熱量，提供外部讀取與設定的介面
        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        // 公開屬性：脂肪(克)，提供外部讀取與設定的介面
        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }

        // 公開屬性：碳水(克)，提供外部讀取與設定的介面
        public double Carb
        {
            get { return carb; }
            set { carb = value; }
        }
    }
}
