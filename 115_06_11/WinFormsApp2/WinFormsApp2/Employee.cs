using System;

namespace WinFormsApp2
{
    /// <summary>
    /// 員工類別（Employee）
    /// 包含：Name、IdNumber、Department、Position
    /// 提供三種建構子：無參數、兩參數、四參數
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 員工姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 員工編號（整數）
        /// </summary>
        public int IdNumber { get; set; }

        /// <summary>
        /// 所屬部門
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 職務/職稱
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 無參數建構子
        /// Name、Department、Position 預設為空字串 ""
        /// IdNumber 預設為 0
        /// </summary>
        public Employee()
        {
            Name = string.Empty;
            IdNumber = 0;
            Department = string.Empty;
            Position = string.Empty;
        }

        /// <summary>
        /// 兩參數建構子：可設定 Name 與 IdNumber
        /// Department、Position 預設為空字串 ""
        /// </summary>
        /// <param name="name">員工姓名</param>
        /// <param name="idNumber">員工編號</param>
        public Employee(string name, int idNumber)
        {
            Name = name ?? string.Empty;
            IdNumber = idNumber;
            Department = string.Empty;
            Position = string.Empty;
        }

        /// <summary>
        /// 四參數建構子：可設定 Name、IdNumber、Department、Position
        /// </summary>
        /// <param name="name">員工姓名</param>
        /// <param name="idNumber">員工編號</param>
        /// <param name="department">所屬部門</param>
        /// <param name="position">職務/職稱</param>
        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name ?? string.Empty;
            IdNumber = idNumber;
            Department = department ?? string.Empty;
            Position = position ?? string.Empty;
        }
    }
}
