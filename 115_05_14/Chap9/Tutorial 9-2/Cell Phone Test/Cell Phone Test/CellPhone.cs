using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Test
{
    /// <summary>
    /// 表示一支手機的資料模型類別（CellPhone）。
    /// 包含品牌、型號與價格三個屬性，以及預設建構子。
    /// </summary>
    class CellPhone
    {
        // 私有欄位，用來儲存屬性值
        private string _brand;
        private string _model;
        private decimal _price;

        /// <summary>
        /// 建構子：初始化欄位，價格預設為 0，避免 null 值。
        /// </summary>
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        /// <summary>
        /// 品牌屬性（Brand）。
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// 型號屬性（Model）。
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// 價格屬性（Price），使用 decimal 表示以便正確處理貨幣與數值運算。
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
