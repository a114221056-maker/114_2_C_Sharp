using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    /// <summary>
    /// 獨立的新增員工表單：允許輸入員工資料並加入到提供的集合中
    /// </summary>
    public class AddEmployeeForm : Form
    {
        private EmployeeForm innerForm;
        private Button btnAdd;
        private Button btnCancel;
        private List<Employee> employees;

        public AddEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "新增員工";
            this.ClientSize = new Size(460, 360);
            this.StartPosition = FormStartPosition.CenterParent;

            innerForm = new EmployeeForm();
            // 將 innerForm 的控制項加入到此表單做為子區域
            innerForm.TopLevel = false;
            innerForm.FormBorderStyle = FormBorderStyle.None;
            innerForm.Dock = DockStyle.Top;
            innerForm.Height = 300;

            btnAdd = new Button() { Text = "新增", Location = new Point(180, 310), Size = new Size(80, 36) };
            btnCancel = new Button() { Text = "取消", Location = new Point(280, 310), Size = new Size(80, 36) };

            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(innerForm);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnCancel);

            innerForm.Show();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            // 模擬按下 innerForm 的確定按鈕，使用其驗證邏輯
            // 透過 reflection 或呼叫 private 方法較麻煩，因此直接從欄位取得並驗證
            var txtName = innerForm.NameTextBox;
            var txtId = innerForm.IdNumberTextBox;
            var txtDept = innerForm.DepartmentTextBox;
            var txtPos = innerForm.PositionTextBox;

            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號請輸入有效的整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 防止重複編號
            if (employees.Any(e => e.IdNumber == id))
            {
                MessageBox.Show($"已存在員工編號 {id}。", "重複編號", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = new Employee(txtName.Text.Trim(), id, txtDept.Text.Trim(), txtPos.Text.Trim());
            employees.Add(emp);
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
