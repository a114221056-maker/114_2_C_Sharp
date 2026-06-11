using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // 員工集合：用來儲存目前的員工資料
        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            // 載入員工資料（若無資料檔則建立初始檔案）
            LoadEmployeesFromFile();

            // 在視窗關閉時儲存員工資料
            this.FormClosing += Form1_FormClosing;
        }

        // 取得 employees.txt 的路徑（設定為執行目錄下）
        private string GetEmployeesFilePath()
        {
            return Path.Combine(AppContext.BaseDirectory, "employees.txt");
        }

        // 若檔案不存在，建立一個初始的 employees.txt
        private void EnsureInitialEmployeesFile()
        {
            var path = GetEmployeesFilePath();
            if (!File.Exists(path))
            {
                var initial = new List<string>
                {
                    // 預設三筆範例資料，格式：IdNumber|Name|Department|Position
                    "1001|王小明|業務部|業務員",
                    "1002|陳美華|人事部|專員",
                    "1003|林志強|研發部|工程師"
                };
                File.WriteAllLines(path, initial, new UTF8Encoding(false));
            }
        }

        // 從 employees.txt 載入員工到 employees 集合
        private void LoadEmployeesFromFile()
        {
            try
            {
                EnsureInitialEmployeesFile();
                var path = GetEmployeesFilePath();
                var lines = File.ReadAllLines(path, Encoding.UTF8);
                employees.Clear();
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        if (int.TryParse(parts[0].Trim(), out int id))
                        {
                            var name = parts[1].Trim();
                            var dept = parts[2].Trim();
                            var pos = parts[3].Trim();
                            employees.Add(new Employee(name, id, dept, pos));
                        }
                        // 若 id 無法解析則跳過該行
                    }
                }
                RefreshEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入員工資料時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 將 employees 集合寫回 employees.txt，格式：IdNumber|Name|Department|Position
        private void SaveEmployeesToFile()
        {
            try
            {
                var path = GetEmployeesFilePath();
                var lines = new List<string>();
                foreach (var e in employees)
                {
                    lines.Add($"{e.IdNumber}|{e.Name}|{e.Department}|{e.Position}");
                }
                File.WriteAllLines(path, lines, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存員工資料時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // 程式關閉時自動儲存
            SaveEmployeesToFile();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            // 使用獨立的新增員工表單來處理新增功能
            using (var form = new AddEmployeeForm(employees))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshEmployeeList();
                }
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            // 使用獨立的刪除員工表單來處理刪除功能
            using (var form = new DeleteEmployeeForm(employees))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshEmployeeList();
                }
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            // 使用獨立的修改員工資料表單來處理編輯功能
            int idx = employeeListBox.SelectedIndex;
            if (idx >= 0 && idx < employees.Count)
            {
                using (var form = new EditEmployeeForm(employees, idx))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        RefreshEmployeeList();
                        employeeListBox.SelectedIndex = idx;
                    }
                }
            }
            else
            {
                MessageBox.Show("請先選擇要修改的員工。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            // 使用獨立的查詢表單進行查詢
            using (var form = new SearchEmployeeForm(employees))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    int idx = form.SelectedIndex;
                    if (idx >= 0)
                    {
                        employeeListBox.SelectedIndex = idx;
                        employeeListBox.TopIndex = Math.Max(0, idx - 3);
                    }
                }
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 重新整理 ListBox 的顯示內容。
        /// 顯示格式：IdNumber[tab]Name，例如：1001    王小明
        /// </summary>
        private void RefreshEmployeeList()
        {
            employeeListBox.Items.Clear();
            foreach (var emp in employees)
            {
                // 使用 tab 分隔顯示編號與姓名
                employeeListBox.Items.Add($"{emp.IdNumber}\t{emp.Name}");
            }
        }
    }
}
