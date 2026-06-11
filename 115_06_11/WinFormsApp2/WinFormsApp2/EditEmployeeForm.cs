using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    /// <summary>
    /// 獨立的修改員工表單：顯示指定索引的員工資料並允許修改
    /// </summary>
    public class EditEmployeeForm : Form
    {
        private EmployeeForm innerForm;
        private Button btnSave;
        private Button btnCancel;
        private List<Employee> employees;
        private int index;

        public EditEmployeeForm(List<Employee> employees, int index)
        {
            this.employees = employees;
            this.index = index;
            InitializeComponent();
            LoadEmployee();
        }

        private void InitializeComponent()
        {
            // 表單基本設定
            this.Text = "修改員工資料";
            this.ClientSize = new Size(600, 520);
            this.StartPosition = FormStartPosition.CenterParent;

            // 大標題
            var lblTitle = new Label() { Text = "修改員工資料", Location = new Point(20, 12), AutoSize = true, Font = new Font("微軟正黑體", 24F) };

            // 搜尋欄位：員工編號
            var lblSearch = new Label() { Text = "員工編號：", Location = new Point(20, 70), AutoSize = true, Font = new Font("微軟正黑體", 14F) };
            var txtSearchId = new TextBox() { Name = "txtSearchId", Location = new Point(140, 66), Size = new Size(360, 30) };
            var btnQuery = new Button() { Text = "查詢", Location = new Point(240, 102), Size = new Size(100, 36) };

            innerForm = new EmployeeForm();
            innerForm.TopLevel = false;
            innerForm.FormBorderStyle = FormBorderStyle.None;
            innerForm.Location = new Point(0, 150);
            innerForm.Width = 600;
            innerForm.Height = 220;

            btnSave = new Button() { Text = "儲存", Location = new Point(180, 380), Size = new Size(100, 44) };
            btnCancel = new Button() { Text = "離開", Location = new Point(300, 380), Size = new Size(100, 44) };

            // 下方的列表區域（顯示用）
            var listBox = new ListBox() { Name = "lbInfo", Location = new Point(20, 440), Size = new Size(560, 60) };

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnQuery.Click += (s, e) =>
            {
                // 查詢輸入的員工編號並載入欄位
                var tb = this.Controls.Find("txtSearchId", true);
                if (tb.Length > 0 && tb[0] is TextBox idBox)
                {
                    if (int.TryParse(idBox.Text.Trim(), out int id))
                    {
                        int found = employees.FindIndex(x => x.IdNumber == id);
                        if (found >= 0)
                        {
                            index = found;
                            LoadEmployee();
                            listBox.Items.Clear();
                            listBox.Items.Add($"已找到：{employees[found].IdNumber}\t{employees[found].Name}");
                        }
                        else
                        {
                            MessageBox.Show($"找不到編號為 {id} 的員工。", "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入有效的數字編號。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearchId);
            this.Controls.Add(btnQuery);
            this.Controls.Add(innerForm);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
            this.Controls.Add(listBox);

            innerForm.Show();
        }

        private void LoadEmployee()
        {
            if (index < 0 || index >= employees.Count) return;
            var emp = employees[index];

            innerForm.NameTextBox.Text = emp.Name;
            innerForm.IdNumberTextBox.Text = emp.IdNumber.ToString();
            innerForm.DepartmentTextBox.Text = emp.Department;
            innerForm.PositionTextBox.Text = emp.Position;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            var txtName = innerForm.NameTextBox;
            var txtId = innerForm.IdNumberTextBox;
            var txtDept = innerForm.DepartmentTextBox;
            var txtPos = innerForm.PositionTextBox;

            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號請輸入有效的整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 檢查是否有其他員工使用同樣的編號
            for (int i = 0; i < employees.Count; i++)
            {
                if (i == index) continue;
                if (employees[i].IdNumber == id)
                {
                    MessageBox.Show($"已存在員工編號 {id}。", "重複編號", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            employees[index] = new Employee(txtName.Text.Trim(), id, txtDept.Text.Trim(), txtPos.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
