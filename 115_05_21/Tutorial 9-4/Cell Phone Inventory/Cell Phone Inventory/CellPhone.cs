using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {
        // 欄位
        private string _brand;   // 手機品牌
        private string _model;   // 手機型號
        private decimal _price;  // 售價

        // 建構函式
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        // 品牌屬性
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // 型號屬性
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // 價格屬性
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
