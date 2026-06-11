using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    /// <summary>
    /// 獨立的查詢員工表單：允許輸入編號或選取列表中的員工，並回傳選取索引
    /// </summary>
    public class SearchEmployeeForm : Form
    {
        private TextBox txtSearch;
        private Button btnQuery;
        private ListBox listBox;
        private Button btnClose;
        private List<Employee> employees;

        public int SelectedIndex { get; private set; } = -1;

        public SearchEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponent();
            LoadList();
        }

        private void InitializeComponent()
        {
            // 表單設定與大標題
            this.Text = "查詢員工";
            this.ClientSize = new Size(600, 420);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Font = new Font("微軟正黑體", 14F);

            var lblTitle = new Label() { Text = "查詢員工", Location = new Point(20, 12), AutoSize = true, Font = new Font("微軟正黑體", 24F) };
            var lblId = new Label() { Text = "員工編號：", Location = new Point(20, 70), AutoSize = true, Font = new Font("微軟正黑體", 14F) };

            txtSearch = new TextBox() { Name = "txtSearchId", Location = new Point(140, 66), Size = new Size(360, 30) };
            btnQuery = new Button() { Text = "查詢", Location = new Point(200, 110), Size = new Size(100, 40) };
            btnClose = new Button() { Text = "離開", Location = new Point(320, 110), Size = new Size(100, 40) };

            listBox = new ListBox() { Location = new Point(20, 170), Size = new Size(560, 220) };

            btnQuery.Click += BtnSearch_Click;
            btnClose.Click += BtnClose_Click;
            listBox.DoubleClick += (s, e) =>
            {
                if (listBox.SelectedIndex >= 0)
                {
                    SelectedIndex = listBox.SelectedIndex;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblId);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnQuery);
            this.Controls.Add(btnClose);
            this.Controls.Add(listBox);
        }

        private void LoadList()
        {
            listBox.Items.Clear();
            foreach (var e in employees)
            {
                listBox.Items.Add($"{e.IdNumber}\t{e.Name}");
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text.Trim(), out int id))
            {
                int idx = employees.FindIndex(x => x.IdNumber == id);
                if (idx >= 0)
                {
                    listBox.SelectedIndex = idx;
                    listBox.TopIndex = Math.Max(0, idx - 3);
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

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            SelectedIndex = listBox.SelectedIndex;
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
