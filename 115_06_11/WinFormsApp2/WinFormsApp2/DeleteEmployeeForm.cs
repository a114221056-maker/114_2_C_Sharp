using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    /// <summary>
    /// 獨立的刪除員工表單：顯示清單並允許使用者選擇刪除項目
    /// </summary>
    public class DeleteEmployeeForm : Form
    {
        private ListBox listBox;
        private Button btnDelete;
        private Button btnCancel;
        private List<Employee> employees;

        public DeleteEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponent();
            LoadList();
        }

        private void InitializeComponent()
        {
            // 表單基本設定
            this.Text = "刪除員工";
            this.ClientSize = new Size(600, 420);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Font = new Font("微軟正黑體", 14F);

            // 大標題（置頂左側，與畫面範例一致）
            var lblTitle = new Label() { Text = "刪除員工", Location = new Point(20, 12), AutoSize = true, Font = new Font("微軟正黑體", 24F) };

            // 員工編號輸入：允許使用者以編號搜尋並刪除（或可直接從下面列表選取）
            var lblId = new Label() { Text = "員工編號：", Location = new Point(20, 70), AutoSize = true, Font = new Font("微軟正黑體", 14F) };
            var txtId = new TextBox() { Name = "txtId", Location = new Point(140, 66), Size = new Size(360, 30) };

            // 列表顯示目前所有員工
            listBox = new ListBox() { Location = new Point(20, 120), Size = new Size(540, 220) };

            // 按鈕：刪除與取消，置於列表上方，符合畫面示意
            btnDelete = new Button() { Text = "刪除", Location = new Point(200, 90), Size = new Size(100, 40) };
            btnCancel = new Button() { Text = "取消", Location = new Point(320, 90), Size = new Size(100, 40) };

            btnDelete.Click += BtnDelete_Click;
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(listBox);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnCancel);
        }

        private void LoadList()
        {
            listBox.Items.Clear();
            foreach (var e in employees)
            {
                listBox.Items.Add($"{e.IdNumber}\t{e.Name}");
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            // 先檢查是否在編號輸入欄有值，若有則以編號刪除；否則以列表選取索引刪除
            var txtId = this.Controls.Find("txtId", true);
            if (txtId.Length > 0 && txtId[0] is TextBox idBox && !string.IsNullOrWhiteSpace(idBox.Text))
            {
                if (int.TryParse(idBox.Text.Trim(), out int id))
                {
                    int idxById = employees.FindIndex(x => x.IdNumber == id);
                    if (idxById >= 0)
                    {
                        var result = MessageBox.Show($"確定要刪除 {employees[idxById].Name}（編號 {employees[idxById].IdNumber}）？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            employees.RemoveAt(idxById);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"找不到編號為 {id} 的員工。", "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的數字編號。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int idx = listBox.SelectedIndex;
            if (idx >= 0 && idx < employees.Count)
            {
                var result = MessageBox.Show($"確定要刪除 {employees[idx].Name}（編號 {employees[idx].IdNumber}）？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    employees.RemoveAt(idx);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("請先選擇要刪除的員工，或於上方輸入員工編號。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
