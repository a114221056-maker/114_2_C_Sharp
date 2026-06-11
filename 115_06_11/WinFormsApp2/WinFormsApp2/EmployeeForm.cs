using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    /// <summary>
    /// 員工輸入/編輯視窗
    /// 提供欄位：Name、IdNumber、Department、Position，並回傳 Employee 物件
    /// </summary>
    public class EmployeeForm : Form
    {
        private Label lblName;
        private TextBox txtName;
        private Label lblIdNumber;
        private TextBox txtIdNumber;
        private Label lblDepartment;
        private TextBox txtDepartment;
        private Label lblPosition;
        private TextBox txtPosition;
        private Button btnOK;
        private Button btnCancel;

        /// <summary>
        /// 使用者輸入或修改後的 Employee 結果
        /// </summary>
        public Employee? EmployeeResult { get; private set; }

        // 對外公開的欄位存取，讓外部表單可以讀取或設定欄位值（避免使用 Controls[] 索引）
        public TextBox NameTextBox => txtName;
        public TextBox IdNumberTextBox => txtIdNumber;
        public TextBox DepartmentTextBox => txtDepartment;
        public TextBox PositionTextBox => txtPosition;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(Employee existing) : this()
        {
            // 將現有資料填入欄位以便編輯
            txtName.Text = existing.Name;
            txtIdNumber.Text = existing.IdNumber.ToString();
            txtDepartment.Text = existing.Department;
            txtPosition.Text = existing.Position;
        }

        private void InitializeComponent()
        {
            this.Text = "員工資料";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(420, 300);
            this.Font = new Font("微軟正黑體", 14F);

            lblName = new Label() { Text = "姓名：", Location = new Point(20, 20), AutoSize = true };
            txtName = new TextBox() { Location = new Point(140, 16), Size = new Size(240, 30) };

            lblIdNumber = new Label() { Text = "員工編號：", Location = new Point(20, 70), AutoSize = true };
            txtIdNumber = new TextBox() { Location = new Point(140, 66), Size = new Size(240, 30) };

            lblDepartment = new Label() { Text = "部門：", Location = new Point(20, 120), AutoSize = true };
            txtDepartment = new TextBox() { Location = new Point(140, 116), Size = new Size(240, 30) };

            lblPosition = new Label() { Text = "職稱：", Location = new Point(20, 170), AutoSize = true };
            txtPosition = new TextBox() { Location = new Point(140, 166), Size = new Size(240, 30) };

            btnOK = new Button() { Text = "確定", Location = new Point(140, 220), Size = new Size(100, 36) };
            btnCancel = new Button() { Text = "取消", Location = new Point(280, 220), Size = new Size(100, 36) };

            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;

            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblIdNumber);
            this.Controls.Add(txtIdNumber);
            this.Controls.Add(lblDepartment);
            this.Controls.Add(txtDepartment);
            this.Controls.Add(lblPosition);
            this.Controls.Add(txtPosition);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
        }

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            // 驗證員工編號是否為整數
            if (!int.TryParse(txtIdNumber.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號請輸入有效的整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 建立 Employee 物件並回傳
            EmployeeResult = new Employee(
                txtName.Text.Trim(),
                id,
                txtDepartment.Text.Trim(),
                txtPosition.Text.Trim()
            );

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
